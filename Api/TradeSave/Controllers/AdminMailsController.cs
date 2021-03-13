using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
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
        private readonly SecurityContext _dbSecurity;

        public AdminMailsController(TradSaveContext db, SecurityContext dbSecurity)
        {
            _db = db;
            _dbSecurity = dbSecurity;
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
                try
                {
                    AdminEmail adminMail = new AdminEmail
                    {
                        Subject = model.Subject,
                        body = model.body,
                        attachment = model.attachment,
                        CreateDate = model.CreateDate,
                        Ispublic = model.Ispublic,
                        IsSent = model.IsSent,
                        SendDate = model.SendDate,
                        GroupId = model.GroupId
                    };

                    await _db.AdminEmails.AddAsync(adminMail);
                    await _db.SaveChangesAsync();

                    return Ok(true);

                }
                catch (Exception ex)
                {
                    return Ok(false);
                }
            }
            else
            {
                return Ok(false);
            }
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
                    return Ok(true);
                }

            }

            return Ok(false);
        }

        [HttpDelete("Delete")]
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
                return Ok(true);
            }

            return Ok(false);
        }

        private static MimeEntity CreateMailBody(string body)
        {
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = body;
            return bodyBuilder.ToMessageBody();
        }

        [HttpPost("SendMail")]
        public async Task<IActionResult> SendMail(CreateAdminMailsViewModel createAdminMailsViewModel)
        {
            MimeMessage message = new MimeMessage();
            MailboxAddress from = new MailboxAddress("notificationservice@Smart-Swing.com", "www.Smart-Swing.com");
            message.From.Add(from);
            
            List<string> usersId = _db.Usergroups.Where(a => a.GroupId == createAdminMailsViewModel.GroupId)
                .Select(a=>a.UserId).ToList();
            foreach (var item in usersId)
            {
                List<string> usersMails = new List<string>();
                string userMail = _dbSecurity.Users.FirstOrDefault(async => async.Id == item).Email;
                usersMails.Add(userMail);
                MailboxAddress to = new MailboxAddress(userMail, userMail);
                message.To.Add(to);
            }

            message.Subject = createAdminMailsViewModel.Subject;

            message.Body = CreateMailBody(createAdminMailsViewModel.body);
            try
            {
                SmtpClient client = new SmtpClient();
                                   //host              port
                
                client.Connect("email-smtp.us-west-2.amazonaws.com", 587, MailKit.Security.SecureSocketOptions.StartTlsWhenAvailable);
                client.Authenticate("AKIAJNMMSQPOKISDZKPA", "AssxZzfyl1CRV4PvNJsy1oef7XHCF4CtTVteDxXygNE7");
                
                client.AuthenticationMechanisms.Remove("XQAUTH2");
                await client.SendAsync(message);
                client.Disconnect(true);
                client.Dispose();
                return Ok(true); 
            }
            catch(Exception ex)
            {
                return Ok(false);
            }

            
        }
    }
    

}
