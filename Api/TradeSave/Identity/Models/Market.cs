using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class Market
    {
        public int Id { get; set; }
        public string MDesc { get; set; }
        public string Tk { get; set; }
        public string Country { get; set; }
        public string ImgPath { get; set; }
        public string DataPath { get; set; }
        public short CntyId { get; set; }
        public short? Filet { get; set; }
        public string Dest { get; set; }
        public short? MktTyp { get; set; }
        public string ImgName { get; set; }
        public string DestHost { get; set; }
        public string CntyIde { get; set; }
        public string MktIde { get; set; }
        public string ExName { get; set; }
    }
}
