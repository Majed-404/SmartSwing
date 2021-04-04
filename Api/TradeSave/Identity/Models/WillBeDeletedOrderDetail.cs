using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class WillBeDeletedOrderDetail
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Id { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public virtual WillBeDeletedOrder Order { get; set; }
        public virtual WillBeDeletedProduct Product { get; set; }
    }
}
