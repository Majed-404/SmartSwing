using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeSave.Identity.Models
{
    public class UserGroup
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string UserId { get; set; }
    }
}
