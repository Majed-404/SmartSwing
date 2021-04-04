using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class MailTxt
    {
        public short Id { get; set; }
        public string Ref { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }
        public short? SendMail { get; set; }
    }
}
