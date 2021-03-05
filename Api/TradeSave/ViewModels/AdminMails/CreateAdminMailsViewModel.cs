using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeSave.ViewModels.AdminMails
{
    public class CreateAdminMailsViewModel
    {
        public string Subject { get; set; }
        public string CreateDate { get; set; }
        public bool IsSent { get; set; }
        public string SendDate { get; set; }
        public bool Ispublic { get; set; }
        public string attachment { get; set; }
        public int? GroupId { get; set; }
    }
}
