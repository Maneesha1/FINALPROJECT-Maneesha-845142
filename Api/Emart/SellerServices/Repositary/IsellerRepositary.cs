using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SellerServices.Models;

namespace SellerServices.Repositary
{
    public interface IsellerRepositary
    {
        void EditProfile(Seller obj);
        Seller GetProfile(string sid);
    }
}
