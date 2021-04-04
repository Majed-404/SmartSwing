using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class NwDataMasRanking
    {
        public short DtNmId { get; set; }
        public string DtDt { get; set; }
        public byte DtMktId { get; set; }
        public short DtRank { get; set; }
        public short? DtRankLastDay { get; set; }
        public short? DtRankQuickCross { get; set; }
    }
}
