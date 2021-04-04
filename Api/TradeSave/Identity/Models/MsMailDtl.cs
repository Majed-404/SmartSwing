using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class MsMailDtl
    {
        public byte SgId { get; set; }
        public string SignEn { get; set; }
        public string SignAr { get; set; }
        public string SigntureEnDesc { get; set; }
        public string SigntureArDesc { get; set; }
    }
}
