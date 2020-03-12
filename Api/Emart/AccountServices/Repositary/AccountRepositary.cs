using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountServices.Models;

namespace AccountServices.Repositary
{
    public class AccountRepositary : IAccountRepositary
    {
        private readonly EmartDBContext _context;
        public AccountRepositary(EmartDBContext context)
        {
            _context = context;
        }
        public Buyer BuyerLogin(string username, string pwd)
        {
            Buyer b = _context.Buyer.SingleOrDefault(bu => bu.UserName == username && bu.Password == pwd);
            return b;
            //if (b != null)
            //{
            //    return b;
            //}
            //else
            //    return null;

        }

        public void BuyerRegister(Buyer obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller SellerLogin(string username, string pwd)
        {
            Seller s = _context.Seller.SingleOrDefault(se => se.UserName == username && se.Password == pwd);
            return s;
            //if (s != null)
            //{
            //    return true;
            //}
            //else
            //    return false;

        }

        public void SellerRegister(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();

        }
    }
}
