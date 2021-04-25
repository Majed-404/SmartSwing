using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class WillBeDeletedProduct
    {
        public WillBeDeletedProduct()
        {
            InverseParent = new HashSet<WillBeDeletedProduct>();
            WillBeDeletedOrderDetails = new HashSet<WillBeDeletedOrderDetail>();
        }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool IsActive { get; set; }
        public bool IsDiscontinued { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int? ParentId { get; set; }
        public int ProductCategoryId { get; set; }

        public virtual WillBeDeletedProduct Parent { get; set; }
        public virtual WillBeDeletedProductCategory ProductCategory { get; set; }
        public virtual ICollection<WillBeDeletedProduct> InverseParent { get; set; }
        public virtual ICollection<WillBeDeletedOrderDetail> WillBeDeletedOrderDetails { get; set; }
    }
}
