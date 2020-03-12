using System;
using System.Collections.Generic;

namespace SellerServices.Models
{
    public partial class Buyer
    {
        public Buyer()
        {
            Cart = new HashSet<Cart>();
            Transactionhistory = new HashSet<Transactionhistory>();
        }

        public string BuyerId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Transactionhistory> Transactionhistory { get; set; }
    }
}
