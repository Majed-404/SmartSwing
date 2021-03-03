using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeSave.Identity.Models;
using TradeSave.ViewModels.Groups;

namespace TradeSave.Controllers
{
    [AllowAnonymous]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class GroupsController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly TradSaveContext _db;

        public GroupsController(TradSaveContext db, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _db = db;
        }

        [HttpGet("ListGroups")]
        public IActionResult ListGroups()
        {
             var groups =_db.groups.ToList();
            return Ok(groups);
        }

        [HttpPost("CreateGroup")]
        public async Task<IActionResult> CreateGroup(GroupViewModel model)
        {
            if (ModelState.IsValid)
            {
                Group group = new Group
                {
                    Name = model.Name
                };

                 await _db.groups.AddAsync(group);
                await _db.SaveChangesAsync();

                return Ok("Success !");
                
            }
            return Ok("Failed !");
        }

        [HttpGet("GetGroupById")]
        public async Task<IActionResult> GetGroupById([FromBody] int id)
        {
            // Find the Group by Group ID
            var Group = await _db.groups.FindAsync(id);

            if (Group == null)
            {
                return Ok($"Group with Id = {id} cannot be found");
            }

            var GroupModel = new GroupViewModel
            {
                Name = Group.Name
            };

            return Ok(GroupModel);
        }

        [HttpPut("EditGroup")]
        public async Task<IActionResult> EditGroup(EditGroupViewModel model)
        {
            var Group = await _db.groups.FindAsync(model.Id);

            if (Group == null)
            {
                return Ok($"Group with Id = {model.Id} cannot be found");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    Group.Name = model.Name;
                    _db.groups.Update(Group);
                    await _db.SaveChangesAsync();
                    return Ok("Success");
                }
                
            }

            return Ok("Failed");
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> DeleteGroup(int Id)
        {
            var Group = await _db.groups.FindAsync(Id);
            var UserGroup = await _db.Usergroups.FindAsync(Id);
            if (Group == null)
            {
                return Ok($"Group with Id = {Id} cannot be found");
            }
            else if(UserGroup!=null)
            {
                    _db.groups.Remove(Group);
                    await _db.SaveChangesAsync();
                    return Ok("Success");
            }

            return Ok("Failed");
        }

        [HttpPost("AddUserToGroup")]
        public async Task<IActionResult> AddUserToGroup(UserGroupViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                var Group = await _db.groups.FindAsync(model.GroupId);
                UserGroup userGroup = new UserGroup()
                {
                    GroupId=model.GroupId,
                    UserId=model.UserId
                };
                await _db.Usergroups.AddAsync(userGroup);
                await _db.SaveChangesAsync();
                
                    return Ok(true);
            }

            return Ok(false);
        }

        //[HttpPost("RemoveUserFromRloe")]
        //public async Task<IActionResult> RemoveUserFromGroup(UserGroupViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await _userManager.FindByIdAsync(model.UserId);
        //        var Group = await _db.groups.FindAsync(model.GroupId);

        //        IdentityResult result = null;

        //        if(u)
        //        if (result.Succeeded)
        //        {
        //            return Ok(true);
        //        }
        //    }

        //    return Ok(false);
        //}
    }
}
