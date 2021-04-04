using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TradeSave.Identity.Models;
using TradeSave.ViewModels.Account;
using TradeSave.ViewModels.JwtAuth;

namespace TradeSave.Controllers
{
    //[AllowAnonymous]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        #region 00.Props
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SecurityContext _db;
        private readonly TradeSaveContext _dbContext;
        #endregion

        #region 01.Constructor
        public AuthController(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SecurityContext db, TradeSaveContext dbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
            _dbContext = dbContext;
        }
        #endregion


        [HttpGet("TestApis")]
        public IActionResult Test()
        {
            return Ok(new string[] { "John Doe", "Jane Doe" });
        }

        #region 02.Login-Register

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                var sdsd = await _userManager.Users.ToListAsync();

                var user = await _userManager.FindByEmailAsync(model.Email);
                var result = await _userManager.CheckPasswordAsync(user, model.Password);

                if (result)
                {
                    // GENERATE TOKEN ...
                    var tokenResult = await CreateToken(user);

                    return Ok(new { token = tokenResult });
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return BadRequest(ModelState);
        }


        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = new IdentityUser
                    {

                        UserName = model.UserName,
                        Email = model.Email
                    };

                    var result = await _userManager.CreateAsync(user, model.Password);

                    if (result.Succeeded)
                    {
                        // GENERATE TOKEN ...
                        var tokenResult = await CreateToken(user);

                        return Ok(new { token = tokenResult });
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                catch (Exception ex)
                {

                    return BadRequest("Exception:" + ex.Message);
                }


            }

            return BadRequest(ModelState);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        private async Task<string> CreateToken(IdentityUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            var roleClaims = new List<Claim>();

            for (int i = 0; i < roles.Count; i++)
            {
                roleClaims.Add(new Claim("roles", roles[i]));
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName)

            }.Union(userClaims).Union(roleClaims);


            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: "Majed",
                audience: "Majed",
                claims: claims,
                expires: DateTime.UtcNow.AddDays(3),
                signingCredentials: signingCredentials);

            string tokenAsString = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

            return tokenAsString;


        }

        #endregion

        #region 03.Roles

        [HttpGet("ListRoles")]
        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;
            return Ok(roles);
        }

        [HttpPost("CreateRole")]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                IdentityResult result = await _roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return Ok(true);
                }
            }
            return Ok(false);
        }

        [HttpGet("GetRoleById")]
        public async Task<IActionResult> GetRoleById([FromBody] GetRoleByIdViewModel model)
        {
            // Find the role by Role ID
            var role = await _roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                return Ok($"Role with Id = {model.Id} cannot be found");
            }

            var roleModel = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            return Ok(roleModel);
        }

        [HttpPut("EditRole")]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                return Ok($"Role with Id = {model.Id} cannot be found");
            }
            else
            {
                role.Name = model.RoleName;

                // Update the Role using UpdateAsync
                var result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return Ok(true);
                }
            }

            return Ok(false);
        }




        #endregion

        #region 04.User-Roles

        

        [HttpPost("RemoveUserFromRloe")]
        public async Task<IActionResult> RemoveUserFromRloe(UserRloeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                var role = await _roleManager.FindByIdAsync(model.RoleId);

                IdentityResult result = null;

                if (await _userManager.IsInRoleAsync(user: user, role: role.Name))
                {
                    result = await _userManager.RemoveFromRoleAsync(user: user, role: role.Name);
                }

                if (result.Succeeded)
                {
                    return Ok(true);
                }
            }

            return Ok(false);
        }

        #endregion

        #region 05.Users

        [HttpGet("UsersList")]
        public async Task<IActionResult> UsersList()
        {
            var users = await _userManager.Users.ToListAsync();
            return Ok(users);
        }

        #endregion
    }
}
