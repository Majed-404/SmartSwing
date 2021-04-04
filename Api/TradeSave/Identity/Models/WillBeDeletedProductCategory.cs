using System;
using System.Collections.Generic;

#nullable disable

namespace TradeSave.Identity.Models
{
    public partial class WillBeDeletedProductCategory
    {
        public WillBeDeletedProductCategory()
        {
            WillBeDeletedProducts = new HashSet<WillBeDeletedProduct>();
        }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<WillBeDeletedProduct> WillBeDeletedProducts { get; set; }
    }
}
