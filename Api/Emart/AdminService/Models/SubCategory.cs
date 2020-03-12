using System;
using System.Collections.Generic;

namespace AdminService.Models
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            Cart = new HashSet<Cart>();
            Items = new HashSet<Items>();
        }

        public string SubcategoryId { get; set; }
        public string SubcategoryName { get; set; }
        public string CategoryId { get; set; }
        public string BriefDetails { get; set; }
        public string Gst { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Items> Items { get; set; }
    }
}
