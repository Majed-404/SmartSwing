using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class WebMsg
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Sub { get; set; }
        public string Cmt { get; set; }
        public byte? Flg { get; set; }
    }
}
