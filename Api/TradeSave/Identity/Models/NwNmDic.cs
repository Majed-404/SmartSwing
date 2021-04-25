using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class NwNmDic
    {
        public short NmId { get; set; }
        public string NmSymbol { get; set; }
        public string NmEnName { get; set; }
        public string NmArName { get; set; }
        public string NmMktId { get; set; }
        public bool NmStopFlag { get; set; }
    }
}
