using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class NwDataMa
    {
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
