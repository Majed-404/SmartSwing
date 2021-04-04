using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class NwExplanation
    {
        public byte? DtValue { get; set; }
        public byte? DtNvalue { get; set; }
        public string PowerTrnd { get; set; }
        public string ShortTerm { get; set; }
        public string Wave { get; set; }
        public string TrndCylDicTrend { get; set; }
    }
}
