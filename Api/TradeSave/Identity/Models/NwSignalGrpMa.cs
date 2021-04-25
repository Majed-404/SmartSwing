using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class NwSignalGrpMa
    {
        public short SignalCnt { get; set; }
        public float Signal { get; set; }
        public byte MktId { get; set; }
        public short SgId { get; set; }
    }
}
