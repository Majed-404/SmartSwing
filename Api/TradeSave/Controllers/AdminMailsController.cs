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
            List<AdminMailsViewModel> mailList = new List<AdminMailsViewModel>();
            foreach (var item in AdminMails)
            {
                var mailsVm =(AdminMailsViewModel) (from g in _db.groups
                              join gu in _db.Usergroups on g.Id equals gu.GroupId
                              where gu.Id == item.GroupId
                              select new AdminMailsViewModel()
                              {
                                  Id=item.Id,
                                  attachment=item.attachment,
                                  body=item.body,
                                   CreateDate=item.CreateDate,
                                   GroupName=g.Name,
                                   Ispublic=item.Ispublic,
                                   IsSent=item.IsSent,
                                   SendDate=item.SendDate,
                                   Subject=item.Subject
                              }).FirstOrDefault();
                mailList.Add(mailsVm);
            }
            return Ok(mailList);
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
                        GroupId = model.GroupId,
                        testMail=model.testMail
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
            
            
            

        [HttpGet]
        [Route("GetAdminMailById/{id}")]
        public async Task<IActionResult> GetAdminMailById( int id)
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
                body = model.body,
                CreateDate = model.CreateDate,
                Ispublic = model.Ispublic,
                IsSent = model.IsSent,
                SendDate = model.SendDate,
                GroupId=model.GroupId,
                testMail=model.testMail
            };

            return Ok(AdminMailModel);
        }

        [HttpPut]
        [Route("EditAdminMail/{Id}")]
        public async Task<IActionResult> EditAdminMail(int Id,[FromBody] EditAdminMailViewModel model)
        {
            var AdminMail = await _db.AdminEmails.FindAsync(Id);

            if (AdminMail == null)
            {
                return Ok($"AdminMail with Id = {Id} cannot be found");
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
                    AdminMail.testMail = model.testMail;
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
        public async Task<IActionResult> SendMail(int id, bool isTest)
        {
            MimeMessage message = new MimeMessage();
            //root@support@mydomain.com
            MailboxAddress from = new MailboxAddress("notificationservice@Smart-Swing.com", "www.Smart-Swing.com");
            message.From.Add(from);
            AdminEmail adminEmail = _db.AdminEmails.Find(id);
            List<string> usersId = _db.Usergroups.Where(a => a.Id == adminEmail.GroupId)
                .Select(a=>a.UserId).ToList();
            if (isTest && adminEmail.testMail!=null)
            {
                MailboxAddress to = new MailboxAddress(adminEmail.testMail, adminEmail.testMail);
                message.To.Add(to);
            }
            else
            {
                foreach (var item in usersId)
                {
                    List<string> usersMails = new List<string>();
                    string userMail = _dbSecurity.Users.FirstOrDefault(async => async.Id == item).Email;
                    usersMails.Add(userMail);
                    MailboxAddress to = new MailboxAddress(userMail, userMail);
                    message.To.Add(to);
                }
            }
            

            message.Subject = adminEmail.Subject;

            message.Body = CreateMailBody(adminEmail.body);
            try
            {
                SmtpClient client = new SmtpClient();
                //host              port 
                client.CheckCertificateRevocation = false;
                client.Connect("email-smtp.us-west-2.amazonaws.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
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
