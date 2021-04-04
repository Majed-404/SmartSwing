using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class AccountDetail
    {
        public int TrkId { get; set; }
        public short? PckgNo { get; set; }
        public int Ui { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public short Cnty { get; set; }
        public short? Price { get; set; }
        public short Month { get; set; }
        public string PmntInfo { get; set; }
        public string PmntType { get; set; }
        public string Notes { get; set; }
        public short? Conf { get; set; }
        public string ConfgChgDate { get; set; }
    }
}
