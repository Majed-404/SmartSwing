using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class List
    {
        public int Ui { get; set; }
        public short MktId { get; set; }
        public string Tk { get; set; }
        public string TkSt { get; set; }
    }
}
