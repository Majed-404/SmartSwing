using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class SelectedTrade
    {
        public string Tk { get; set; }
        public short? MktId { get; set; }
        public string Advise { get; set; }
        public short? MsgType { get; set; }
        public string LstSignalDt { get; set; }
    }
}
