using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class HomeRange1
    {
        public string Country { get; set; }
        public string ORange { get; set; }
        public int? Trades { get; set; }
        public int? Cnt { get; set; }
        public double? TradeRange { get; set; }
        public short? CntyId { get; set; }
        public short? MktId { get; set; }
    }
}
