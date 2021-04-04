using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class SpMoneyManagmentSumNew
    {
        public string Year { get; set; }
        public float TotalAmount { get; set; }
        public float TotalPct { get; set; }
        public string Stgy { get; set; }
        public int Cnt { get; set; }
        public byte? MktId { get; set; }
    }
}
