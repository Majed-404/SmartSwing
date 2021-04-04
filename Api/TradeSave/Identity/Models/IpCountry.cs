using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class IpCountry
    {
        public long IpFrom { get; set; }
        public long? IpTo { get; set; }
        public string CountryCode2 { get; set; }
        public string CountryCode3 { get; set; }
        public string CountryName { get; set; }
    }
}
