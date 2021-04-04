using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class FxTimeFrame
    {
        public short FxId { get; set; }
        public string FxTimeFrame1 { get; set; }
        public byte? FxDefault { get; set; }
    }
}
