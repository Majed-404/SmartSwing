using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class Login
    {
        public int Serno { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Pass { get; set; }
        public int? Lev { get; set; }
        public int? CntEntry { get; set; }
        public short? SendMail { get; set; }
        public short? Type { get; set; }
    }
}
