using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class Usergroup
    {
        public Usergroup()
        {
            AdminEmails = new HashSet<AdminEmail>();
        }

        public int Id { get; set; }
        public int GroupId { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<AdminEmail> AdminEmails { get; set; }
    }
}
