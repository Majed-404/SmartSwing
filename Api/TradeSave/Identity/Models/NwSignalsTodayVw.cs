using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class NwSignalsTodayVw
    {
        public short TkId { get; set; }
        public short MktId { get; set; }
        public short? SsdPost { get; set; }
        public short? MacdSg { get; set; }
        public short? StochSg { get; set; }
        public float? Adxr { get; set; }
        public float? Dp { get; set; }
        public float? Dm { get; set; }
        public float? Rsima { get; set; }
    }
}
