using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class AllMarketLastDay
    {
        public string Dtlt { get; set; }
        public string Country { get; set; }
        public short? MktId { get; set; }
        public short? CntyId { get; set; }
        public string Mt { get; set; }
    }
}
