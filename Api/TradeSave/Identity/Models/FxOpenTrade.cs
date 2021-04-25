using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class FxOpenTrade
    {
        public string EntryDate { get; set; }
        public string EntryTime { get; set; }
        public float EntryPrice { get; set; }
        public string ExitDate { get; set; }
        public string ExitTime { get; set; }
        public float? ExitPrice { get; set; }
        public float? Profit { get; set; }
        public string FxSymbol { get; set; }
        public int FxId { get; set; }
        public string FxEntryTypeDesc { get; set; }
        public string FxStrategyDetail { get; set; }
        public string FxTimeFrame { get; set; }
    }
}
