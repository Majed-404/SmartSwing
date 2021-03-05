using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeSave.ViewModels.AdminMails
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditAdminMailViewModel : ControllerBase
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string CreateDate { get; set; }
        public bool IsSent { get; set; }
        public string SendDate { get; set; }
        public bool Ispublic { get; set; }
        public string attachment { get; set; }
    }
}
