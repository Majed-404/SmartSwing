using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class MsMailMa
    {
        public short Id { get; set; }
        public string Title { get; set; }
        public byte UserGrp { get; set; }
        public byte Mkt { get; set; }
        public string BodyEn { get; set; }
        public string BodyAr { get; set; }
        public string Header { get; set; }
        public short? EnSgin { get; set; }
        public short? ArSgin { get; set; }
        public byte? Ready { get; set; }
    }
}
