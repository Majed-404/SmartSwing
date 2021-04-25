using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class FPricesOldSignalInd
    {
        public string DtS { get; set; }
        public string Tk { get; set; }
        public string Dt { get; set; }
        public float? Price { get; set; }
        public string Flg { get; set; }
        public float? DealPft { get; set; }
        public float? DealPftPcnt { get; set; }
        public string Nm { get; set; }
        public string DtD { get; set; }
        public string Mt { get; set; }
        public short MktId { get; set; }
    }
}
