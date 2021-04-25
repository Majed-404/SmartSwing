using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class MarketIndicator
    {
        public string Tk { get; set; }
        public string Dt { get; set; }
        public float Cl { get; set; }
        public short? TrendIdFk { get; set; }
        public short MktId { get; set; }
    }
}
