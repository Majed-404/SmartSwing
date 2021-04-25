using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class WillBeDeletedOrder
    {
        public WillBeDeletedOrder()
        {
            WillBeDeletedOrderDetails = new HashSet<WillBeDeletedOrderDetail>();
        }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Id { get; set; }
        public decimal Discount { get; set; }
        public string Comments { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string CashierId { get; set; }
        public int CustomerId { get; set; }

        public virtual AspNetUser Cashier { get; set; }
        public virtual WillBeDeletedCustomer Customer { get; set; }
        public virtual ICollection<WillBeDeletedOrderDetail> WillBeDeletedOrderDetails { get; set; }
    }
}
