using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class FxTradesMasVwLastTrade
    {
        public int FxPairId { get; set; }
        public string EntryDate { get; set; }
        public string EntryTime { get; set; }
    }
}
