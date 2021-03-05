using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradeSave.Identity.Models;
using TradeSave.ViewModels.AdminMails;

namespace TradeSave.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminMailsController : ControllerBase
    {
        private readonly TradSaveContext _db;

        public AdminMailsController(TradSaveContext db)
        {
            _db = db;
        }

        [HttpGet("ListAdminMails")]
        public IActionResult ListAdminMails()
        {
            var AdminMails = _db.AdminEmails.ToList();
            return Ok(AdminMails);
        }

        [HttpPost("CreateAdminMail")]
        public async Task<IActionResult> CreateAdminMail(CreateAdminMailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                AdminEmail adminMail = new AdminEmail
                {
                    Subject=model.Subject,
                    attachment=model.attachment,
                    CreateDate=model.CreateDate,
                    Ispublic=model.Ispublic,
                    IsSent=model.IsSent,
                    SendDate=model.SendDate,
                    GroupId=model.GroupId
                };

                await _db.AdminEmails.AddAsync(adminMail);
                await _db.SaveChangesAsync();

                return Ok("Success !");

            }
            return Ok("Failed !");
        }

        [HttpGet("GetAdminMailById")]
        public async Task<IActionResult> GetAdminMailById([FromBody] int id)
        {
            // Find the AdminMail by AdminMail ID
            var model = await _db.AdminEmails.FindAsync(id);

            if (model == null)
            {
                return Ok($"AdminMail with Id = {id} cannot be found");
            }

            var AdminMailModel = new CreateAdminMailsViewModel
            {
                Subject = model.Subject,
                attachment = model.attachment,
                CreateDate = model.CreateDate,
                Ispublic = model.Ispublic,
                IsSent = model.IsSent,
                SendDate = model.SendDate,
                GroupId=model.GroupId
            };

            return Ok(AdminMailModel);
        }

        [HttpPut("EditAdminMail")]
        public async Task<IActionResult> EditAdminMail(EditAdminMailViewModel model)
        {
            var AdminMail = await _db.AdminEmails.FindAsync(model.Id);

            if (AdminMail == null)
            {
                return Ok($"AdminMail with Id = {model.Id} cannot be found");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    AdminMail.Subject = model.Subject;
                    AdminMail.attachment = model.attachment;
                    AdminMail.CreateDate = model.CreateDate;
                    AdminMail.SendDate = model.SendDate;
                    AdminMail.IsSent = model.IsSent;
                    AdminMail.Ispublic = model.Ispublic;
                    AdminMail.GroupId = model.GroupId;
                    _db.AdminEmails.Update(AdminMail);
                    await _db.SaveChangesAsync();
                    return Ok("Success");
                }

            }

            return Ok("Failed");
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> DeleteAdminMail(int Id)
        {
            var AdminMail = await _db.AdminEmails.FindAsync(Id);
            if (AdminMail == null)
            {
                return Ok($"AdminMail with Id = {Id} cannot be found");
            }
            else
            {
                _db.AdminEmails.Remove(AdminMail);
                await _db.SaveChangesAsync();
                return Ok("Success");
            }

            return Ok("Failed");
        }
    }
}
