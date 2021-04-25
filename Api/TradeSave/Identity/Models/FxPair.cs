using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class FxPair
    {
        public short FxId { get; set; }
        public string FxSymbol { get; set; }
        public byte? FxEnable { get; set; }
    }
}
