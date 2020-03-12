using System;
using System.Collections.Generic;

namespace AccountServices.Models
{
    public partial class Seller
    {
        public Seller()
        {
            Cart = new HashSet<Cart>();
            Items = new HashSet<Items>();
            Transactionhistory = new HashSet<Transactionhistory>();
        }

        public string SellerId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string Gstin { get; set; }
        public string BriefDetails { get; set; }
        public string PostalAddress { get; set; }
        public string Website { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Items> Items { get; set; }
        public virtual ICollection<Transactionhistory> Transactionhistory { get; set; }
    }
}
