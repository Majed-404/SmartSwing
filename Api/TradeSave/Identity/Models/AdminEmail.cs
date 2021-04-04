using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public class AdminEmail
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string CreateDate { get; set; }
        public bool IsSent { get; set; }
        public string SendDate { get; set; }
        public bool Ispublic { get; set; }
        public string Attachment { get; set; }
        public string TestMail { get; set; }
        public int? GroupId { get; set; }

        public virtual Usergroup Group { get; set; }
    }
}
