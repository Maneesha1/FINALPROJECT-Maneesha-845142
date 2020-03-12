using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountServices.Models;

namespace AccountServices.Repositary
{
    public interface IAccountRepositary
    {
        Buyer BuyerLogin(string username, string pwd);
        Seller SellerLogin(string username, string pwd);
        void SellerRegister(Seller obj);
        void BuyerRegister(Buyer obj);



    }
}
