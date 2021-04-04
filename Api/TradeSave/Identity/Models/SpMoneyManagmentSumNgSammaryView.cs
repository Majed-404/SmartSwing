using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class SpMoneyManagmentSumNgSammaryView
    {
        public int? WinYearCnt { get; set; }
        public int? LoseYearCnt { get; set; }
        public double? Perf { get; set; }
        public double? TotalPct { get; set; }
        public int? TradeCnt { get; set; }
        public int? WinTradeCnt { get; set; }
        public int? LoseTradeCnt { get; set; }
        public string TradingSysNo1 { get; set; }
        public byte MktId { get; set; }
        public short? PdivTo { get; set; }
        public short? StopLoseTest { get; set; }
        public short TradingSysNo { get; set; }
        public string Signals { get; set; }
        public string MktTrend { get; set; }
    }
}
