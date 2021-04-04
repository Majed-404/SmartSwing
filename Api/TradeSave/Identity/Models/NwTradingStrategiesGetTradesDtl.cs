using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class NwTradingStrategiesGetTradesDtl
    {
        public short? Id { get; set; }
        public short? StrategyIdFk { get; set; }
        public short? MarketId { get; set; }
        public int? SymbolId { get; set; }
        public string EntryDate { get; set; }
        public float? EntryPrice { get; set; }
        public string ExitDate { get; set; }
        public float? LastPrice { get; set; }
        public float? Profit { get; set; }
        public short? NbBarsHeld { get; set; }
        public string IsClosed { get; set; }
        public string CloseReason { get; set; }
        public string Rank { get; set; }
        public int? NbShares { get; set; }
        public string IsLong { get; set; }
    }
}
