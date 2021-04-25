using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class SpMoneyManagmentSumNg
    {
        public string Year { get; set; }
        public float TotalAmount { get; set; }
        public float TotalPct { get; set; }
        public int Cnt { get; set; }
        public int? WinnerCnt { get; set; }
        public int? LoseCnt { get; set; }
        public float? Performance { get; set; }
        public byte MktId { get; set; }
        public short TradingSysNo { get; set; }
        public short? PdivTo { get; set; }
        public short? StopLoseTest { get; set; }
        public string Signals { get; set; }
        public string MktTrend { get; set; }
    }
}
