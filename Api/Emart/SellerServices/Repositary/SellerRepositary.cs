using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SellerServices.Models;

namespace SellerServices.Repositary
{
    public class SellerRepositary : IsellerRepositary
    {
        private readonly EmartDBContext _context;
        public SellerRepositary(EmartDBContext context)
        {
            _context = context;
        }
        public void EditProfile(Seller obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }

        public Seller GetProfile(string sid)
        {
            return _context.Seller.Find(sid);
        }
    }
}
