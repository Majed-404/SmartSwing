using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class HomeTk
    {
        public string Tk { get; set; }
        public string Nm { get; set; }
        public string Dt { get; set; }
        public float? Price { get; set; }
        public string Flg { get; set; }
        public float? DealPft { get; set; }
        public float? DealPftPcnt { get; set; }
        public int? CntTrade { get; set; }
        public int? CntPft { get; set; }
        public string Country { get; set; }
        public string ImgPath { get; set; }
        public string MDesc { get; set; }
        public short CntyId { get; set; }
        public int MktId { get; set; }
        public string DtD { get; set; }
        public string DPftPct { get; set; }
    }
}
