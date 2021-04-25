using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class PricesWeekly
    {
        public string Tk { get; set; }
        public string Nm { get; set; }
        public string Dt { get; set; }
        public string Op { get; set; }
        public string Hi { get; set; }
        public string Lo { get; set; }
        public string Cl { get; set; }
        public string Vol { get; set; }
        public string MktId { get; set; }
    }
}
