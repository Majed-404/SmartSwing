using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class Qoute
    {
        public short? Id { get; set; }
        public string Name { get; set; }
        public string Last { get; set; }
        public string Change { get; set; }
        public string Time { get; set; }
        public string Changepct { get; set; }
    }
}
