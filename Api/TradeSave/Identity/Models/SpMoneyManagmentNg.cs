using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class SpMoneyManagmentNg
    {
        public int RowId { get; set; }
        public short NmId { get; set; }
        public string Stdate { get; set; }
        public float Stprice { get; set; }
        public string Endate { get; set; }
        public float? Endprice { get; set; }
        public float? Profit { get; set; }
        public byte? Lo { get; set; }
        public float? Amount { get; set; }
        public float? TotYearAmount { get; set; }
        public byte? MktId { get; set; }
        public short TradingSysNo { get; set; }
    }
}
