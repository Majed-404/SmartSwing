using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class NwTradesMasVwOrginal1
    {
        public short TrNmId { get; set; }
        public string Stdate { get; set; }
        public float BuyPrice { get; set; }
        public string Endate { get; set; }
        public float? SellPrice { get; set; }
        public float? Profit { get; set; }
        public string StyType { get; set; }
        public string NmEnName { get; set; }
        public string NmSymbol { get; set; }
        public float DtClose { get; set; }
        public byte MktTrend { get; set; }
        public short DtRank { get; set; }
        public short? DtRankLastDay { get; set; }
        public short? DtRankQuickCross { get; set; }
    }
}
