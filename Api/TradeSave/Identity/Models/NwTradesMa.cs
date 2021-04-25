using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class NwTradesMa
    {
        public int TradeId { get; set; }
        public short TrNmId { get; set; }
        public string Stdate { get; set; }
        public float BuyPrice { get; set; }
        public string Endate { get; set; }
        public float? SellPrice { get; set; }
        public float? Profit { get; set; }
        public string StyType { get; set; }
        public byte MktTrend { get; set; }
        public int TmMktId { get; set; }
    }
}
