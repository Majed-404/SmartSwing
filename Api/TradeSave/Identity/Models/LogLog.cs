using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class LogLog
    {
        public int Serno { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Pass { get; set; }
        public int? Lev { get; set; }
        public int? CntEntry { get; set; }
        public int? TrkId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Country { get; set; }
        public short? SendMail { get; set; }
        public string PmntType { get; set; }
        public string PmntInfo { get; set; }
        public int? Ui { get; set; }
        public short? Cnty { get; set; }
        public short? Month { get; set; }
        public short? Price { get; set; }
        public string ImgPath { get; set; }
        public short? Conf { get; set; }
        public string Notes { get; set; }
        public short? CntyId { get; set; }
        public string ImgName { get; set; }
        public int? Id { get; set; }
        public string MDesc { get; set; }
        public short? PckgNo { get; set; }
        public string ConfgChgDate { get; set; }
    }
}
