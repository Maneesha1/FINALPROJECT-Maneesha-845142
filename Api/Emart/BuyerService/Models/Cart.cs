using System;
using System.Collections.Generic;

namespace BuyerService.Models
{
    public partial class Cart
    {
        public string CartId { get; set; }
        public string BuyerId { get; set; }
        public string CategoryId { get; set; }
        public string SubcategoryId { get; set; }
        public string SellerId { get; set; }
        public string ItemId { get; set; }
        public string Itemname { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public virtual Buyer Buyer { get; set; }
        public virtual Category Category { get; set; }
        public virtual Items Item { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual SubCategory Subcategory { get; set; }
    }
}
