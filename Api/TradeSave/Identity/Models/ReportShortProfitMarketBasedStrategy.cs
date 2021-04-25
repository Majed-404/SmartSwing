using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class ReportShortProfitMarketBasedStrategy
    {
        public string NmSymbol { get; set; }
        public string Name { get; set; }
        public string Profit { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public byte? DtNvalue { get; set; }
        public double? ProfitNet { get; set; }
        public string Power { get; set; }
        public string ShortInd { get; set; }
        public byte? DtValue { get; set; }
        public float DtOpen { get; set; }
        public float DtClose { get; set; }
        public string NmArName { get; set; }
        public string TasiPower { get; set; }
        public byte DtMktId { get; set; }
        public string CycleTrend { get; set; }
        public string Wave { get; set; }
    }
}
