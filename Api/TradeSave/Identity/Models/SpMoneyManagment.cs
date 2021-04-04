using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class SpMoneyManagment
    {
        public string Tk { get; set; }
        public string Nm { get; set; }
        public string Stdate { get; set; }
        public string Endate { get; set; }
        public float Profit { get; set; }
        public byte Lo { get; set; }
        public float? Amount { get; set; }
        public float? TotYearAmount { get; set; }
        public byte? MktId { get; set; }
    }
}
