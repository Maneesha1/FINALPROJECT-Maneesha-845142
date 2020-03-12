using System;
using System.Collections.Generic;

namespace AccountServices.Models
{
    public partial class Items
    {
        public Items()
        {
            Cart = new HashSet<Cart>();
            Transactionhistory = new HashSet<Transactionhistory>();
        }

        public string SellerId { get; set; }
        public string ItemId { get; set; }
        public string CategoryId { get; set; }
        public string SubcategoryId { get; set; }
        public string Price { get; set; }
        public string ItemName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string StockNumber { get; set; }
        public string Remarks { get; set; }

        public virtual Category Category { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual SubCategory Subcategory { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Transactionhistory> Transactionhistory { get; set; }
    }
}
