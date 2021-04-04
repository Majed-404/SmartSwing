using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class PriceCom
    {
        public int Ser { get; set; }
        public int Id { get; set; }
        public string Mt { get; set; }
        public int Month { get; set; }
        public int Price { get; set; }
        public string Saved { get; set; }
        public string PeriodType { get; set; }
        public short? VisbleFlg { get; set; }
        public short? Type { get; set; }
    }
}
