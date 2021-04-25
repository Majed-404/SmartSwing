using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class FxTradesMa
    {
        public int FxId { get; set; }
        public int FxPairId { get; set; }
        public byte FxTimeFrameId { get; set; }
        public byte FxStrategyId { get; set; }
        public short FxEntryTypeId { get; set; }
        public string EntryDate { get; set; }
        public string EntryTime { get; set; }
        public float EntryPrice { get; set; }
        public string ExitDate { get; set; }
        public string ExitTime { get; set; }
        public float? ExitPrice { get; set; }
        public float? Profit { get; set; }
        public float? Tp { get; set; }
        public float? Sl { get; set; }
    }
}
