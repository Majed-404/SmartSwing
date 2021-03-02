using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TradeSave.ViewModels.Account
{
    public class GetRoleByIdViewModel
    {
        [Required]
        public string Id { get; set; }
    }
}
