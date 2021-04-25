using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class PmStreportUvw
    {
        public string TdTk { get; set; }
        public string TdStartDate { get; set; }
        public string TdEndDate { get; set; }
        public string Profit { get; set; }
        public int? TdDuration { get; set; }
        public int TradePct { get; set; }
        public int Trades { get; set; }
        public int Duration { get; set; }
        public string ProfitPctPd { get; set; }
        public short TdMktId { get; set; }
        public double TdPrice { get; set; }
        public double? TdCl { get; set; }
        public string Nm { get; set; }
        public string Trend { get; set; }
        public float? TodayCl { get; set; }
        public string LiveTrendPower { get; set; }
        public string TrendPower { get; set; }
        public float? Adxrdiff { get; set; }
    }
}
