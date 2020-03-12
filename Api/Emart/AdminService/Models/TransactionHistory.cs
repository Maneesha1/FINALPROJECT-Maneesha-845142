using System;
using System.Collections.Generic;

namespace AdminService.Models
{
    public partial class Transactionhistory
    {
        public string TransactionId { get; set; }
        public string BuyerId { get; set; }
        public string SellerId { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string NumberOfItems { get; set; }
        public DateTime DateTime { get; set; }
        public string TransactionType { get; set; }

        public virtual Buyer Buyer { get; set; }
        public virtual Items Item { get; set; }
        public virtual Seller Seller { get; set; }
    }
}
