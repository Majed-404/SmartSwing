using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class AppTradeLanguage
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
