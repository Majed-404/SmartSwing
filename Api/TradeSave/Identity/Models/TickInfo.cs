using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class TickInfo
    {
        public int TickId { get; set; }
        public string TickSymbol { get; set; }
        public string TickName { get; set; }
    }
}
