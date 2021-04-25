using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class FSummery
    {
        public string Tk { get; set; }
        public decimal? DPft { get; set; }
        public string DPftPct { get; set; }
        public int? CntPft { get; set; }
        public int? CntLos { get; set; }
        public int? CntTrade { get; set; }
        public int? Sgy { get; set; }
        public decimal? PerDeal { get; set; }
        public int? TkProfit { get; set; }
        public string Mt { get; set; }
        public string Nm { get; set; }
        public string Country { get; set; }
        public short MktId { get; set; }
        public int? Stop { get; set; }
    }
}
