using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class LastDaySignal
    {
        public string DtDt { get; set; }
        public string St { get; set; }
        public string Power { get; set; }
        public byte DtMktId { get; set; }
        public short NmId { get; set; }
        public string NmMktId { get; set; }
    }
}
