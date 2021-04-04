using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class MsEmailSysSetting
    {
        public int MailSentCnt { get; set; }
        public string SentDate { get; set; }
        public string Temp { get; set; }
        public int? LastMailSentTo { get; set; }
    }
}
