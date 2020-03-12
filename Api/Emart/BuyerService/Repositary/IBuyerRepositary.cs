using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyerService.Models;

namespace BuyerService.Repositary
{
    public interface IBuyerRepositary
    {
        List<Items> SearchItems(string name);
        void BuyItem(Transactionhistory obj);
        void EditProfile(Buyer obj);
       // List<Buyer> ViewProfile();

        Buyer ViewProfile(string bid);
        List<Transactionhistory> Transactionhistory(string id);
        List<Category> GetCategories();
        List<SubCategory> GetSubCategories(string catagoryid);
        void Addtocart(Cart cartobj);

        void Deletefromcart(string cartid);

       
        List<Cart> ViewCart(string bid);

       // List<Transactionhistory> PurchaseHistory(string bid);



    }
}
