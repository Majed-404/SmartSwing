using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TradeSave.ViewModels.Groups
{
    public class UserGroupViewModel
    {
        [Required]
        public int GroupId { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
