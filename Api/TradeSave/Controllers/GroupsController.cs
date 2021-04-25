﻿using Microsoft.AspNetCore.Authorization;
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
        private readonly TradeSaveContext _db;

        public GroupsController(TradeSaveContext db, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _db = db;
        }

        [HttpGet("ListGroups")]
        public IActionResult ListGroups()
        {
             var groups =_db.Groups.ToList();
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

                 await _db.Groups.AddAsync(group);
                await _db.SaveChangesAsync();

                return Ok(true);
                
            }
            return Ok(false);
        }

        [HttpGet("GetGroupById")]
        public async Task<IActionResult> GetGroupById([FromBody] int id)
        {
            // Find the Group by Group ID
            var Group = await _db.Groups.FindAsync(id);

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
            var Group = await _db.Groups.FindAsync(model.Id);

            if (Group == null)
            {
                return Ok($"Group with Id = {model.Id} cannot be found");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    Group.Name = model.Name;
                    _db.Groups.Update(Group);
                    await _db.SaveChangesAsync();
                    return Ok(true);
                }
                
            }

            return Ok(false);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteGroup(int Id)
        {
            var Group = await _db.Groups.FindAsync(Id);
            var UserGroup = _db.Usergroups.FirstOrDefault(a=>a.GroupId==Id);
            if (Group == null)
            {
                return Ok($"Group with Id = {Id} cannot be found");
            }
            else if(UserGroup!=null)
            {
                    _db.Groups.Remove(Group);
                   _db.Usergroups.Remove(UserGroup);
                    await _db.SaveChangesAsync();
                    return Ok(true);
            }
            else
            {
                _db.Groups.Remove(Group);
                await _db.SaveChangesAsync();
                return Ok(true);
            }
            
        }

        [HttpPost("AddUserToGroup")]
        public async Task<IActionResult> AddUserToGroup(UserGroupViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                var Group = await _db.Groups.FindAsync(model.GroupId);
                Usergroup userGroup = new Usergroup()
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

        [HttpGet("ListUserGroups")]
        public IActionResult ListUserGroups()
        {
            var groups = _db.Usergroups.ToList();
            List<UserGroupListViewModel> listUserGroups=new List<UserGroupListViewModel>();
            if (groups != null)
            {
                foreach (var item in groups)
                {
                    UserGroupListViewModel userGroupVm = new UserGroupListViewModel();
                    userGroupVm.Id = item.Id;
                    userGroupVm.Name = _db.Groups.FirstOrDefault(a => a.Id == item.GroupId).Name;
                    listUserGroups.Add(userGroupVm);
                }
                return Ok(listUserGroups);
            }
            else
            {
                return Ok("Groups is empty");
            }
            
        }

        //[HttpPost("RemoveUserFromRloe")]
        //public async Task<IActionResult> RemoveUserFromGroup(UserGroupViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await _userManager.FindByIdAsync(model.UserId);
        //        var Group = await _db.Groups.FindAsync(model.GroupId);

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
