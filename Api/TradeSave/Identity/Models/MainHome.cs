using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class MainHome
    {
        public int Id { get; set; }
        public string MDesc { get; set; }
        public string Country { get; set; }
        public int? CntTrade { get; set; }
        public int? CntPft { get; set; }
        public double? PerDeal { get; set; }
        public string Pct { get; set; }
        public double? Pct1 { get; set; }
        public short? CntyId { get; set; }
        public short? MktId { get; set; }
        public string ImgPath { get; set; }
    }
}
