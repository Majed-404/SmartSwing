using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class LatestSuccessfulSignalsTrading
    {
        public string DtDt { get; set; }
        public string NmSymbol { get; set; }
        public string NmEnName { get; set; }
        public float DtClose { get; set; }
        public float DtOpen { get; set; }
        public float? TodayProfit { get; set; }
        public string St { get; set; }
        public string Power { get; set; }
        public string Xst { get; set; }
        public string Xpower { get; set; }
        public byte DtMktId { get; set; }
    }
}
