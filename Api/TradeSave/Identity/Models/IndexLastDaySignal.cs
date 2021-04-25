using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class IndexLastDaySignal
    {
        public string Indx { get; set; }
        public string Nm { get; set; }
        public string Flg { get; set; }
        public string Country { get; set; }
        public short? CntyId { get; set; }
        public string Mt { get; set; }
        public short? MktId { get; set; }
    }
}
