using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class StockExchange
    {
        public short NmId { get; set; }
        public string NmSymbol { get; set; }
        public string NmEnName { get; set; }
        public string NmArName { get; set; }
        public string NmMktId { get; set; }
        public bool NmStopFlag { get; set; }
        public short DtNmId { get; set; }
        public string DtDt { get; set; }
        public float DtOpen { get; set; }
        public float DtLow { get; set; }
        public float DtHigh { get; set; }
        public float DtClose { get; set; }
        public int DtVol { get; set; }
        public byte DtMktId { get; set; }
        public byte? DtValue { get; set; }
        public byte? DtNvalue { get; set; }
    }
}
