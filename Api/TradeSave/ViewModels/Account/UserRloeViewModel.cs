using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TradeSave.ViewModels.Account
{
    public class UserRloeViewModel
    {
        [Required]
        public string RoleId { get; set; }
        
        [Required]
        public string UserId { get; set; }
    }
}
