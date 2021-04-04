using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class NwSignalDic
    {
        public short SgId { get; set; }
        public string SgDescAr { get; set; }
        public string SgDescEn { get; set; }
        public byte? Ord { get; set; }
        public short? Type { get; set; }
    }
}
