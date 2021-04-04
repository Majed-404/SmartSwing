using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class NwTradingStrategiesMaster
    {
        public byte? Id { get; set; }
        public int? StrategyId { get; set; }
        public string StrategyVersionIdExpiryDate { get; set; }
        public string StrategyName { get; set; }
        public string StrategyDescription { get; set; }
        public string MarketId { get; set; }
        public string SourceAccountName { get; set; }
        public string SimulatorName { get; set; }
        public byte? DisableFlag { get; set; }
        public float? AnnualReturn { get; set; }
        public float? Drawdown { get; set; }
        public float? Sharpe { get; set; }
        public float? PercentageWinners { get; set; }
    }
}
