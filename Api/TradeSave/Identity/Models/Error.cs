using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class Error
    {
        public long Id { get; set; }
        public string Func { get; set; }
        public string Err { get; set; }
    }
}
