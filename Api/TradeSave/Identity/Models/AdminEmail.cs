using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradeSave.Identity.Models
{
    public class AdminEmail
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string CreateDate { get; set; }
        public bool IsSent { get; set; }
        public string SendDate { get; set; }
        public bool Ispublic { get; set; }
        public string attachment { get; set; }

        [ForeignKey("UserGroup")]
        public int? GroupId { get; set; }
        public virtual UserGroup UserGroup { get; set; }
    }
}
