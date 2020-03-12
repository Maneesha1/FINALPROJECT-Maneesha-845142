using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyerService.Models;
using BuyerService.Repositary;

namespace BuyerService.Repositary
{
    public class BuyerRepositary : IBuyerRepositary
    {
        private readonly EmartDBContext _context;
        public BuyerRepositary(EmartDBContext context)
        {
            _context = context;
        }

        public void BuyItem(Transactionhistory obj)
        {
            _context.Transactionhistory.Add(obj);
            _context.SaveChanges();

        }

        public void EditProfile(Buyer obj)
        {
            _context.Buyer.Update(obj);
            _context.SaveChanges();

        }

        public List<Category> GetCategories()
        {
            return _context.Category.ToList();
        }

        public Buyer ViewProfile(string bid)
        {
            return _context.Buyer.Find(bid);

        }

        public List<SubCategory> GetSubCategories(string catagoryid)
        {
            return _context.SubCategory.Where(res => res.CategoryId == catagoryid).ToList();
        }

        public List<Items> SearchItems(string name)
        {
            return _context.Items.Where(res => res.ItemName == name).ToList();


        }

       
        public void Addtocart(Cart cartobj)
        {
            _context.Cart.Add(cartobj);
            _context.SaveChanges();
        }

        public void Deletefromcart(string cartid)
        {
            Cart cartobj = _context.Cart.Find(cartid);
            _context.Remove(cartobj);
            _context.SaveChanges();
        }

        
        public List<Transactionhistory> Transactionhistory(string id)
        {
            return _context.Transactionhistory.Where(res => res.BuyerId == id).ToList();

        }

        public List<Cart> ViewCart(string bid)
        {
            return _context.Cart.Where(res => res.BuyerId == bid).ToList();
        }

        //public List<Transactionhistory> PurchaseHistory(string bid)
        //{
        //    return _context.Transactionhistory.Where(res => res.BuyerId == bid).ToList();
        //}
        
        
    }



    //public List<Buyer> ViewProfile()
    //{
    //    return _context.Buyer.ToList();
    //}
}

