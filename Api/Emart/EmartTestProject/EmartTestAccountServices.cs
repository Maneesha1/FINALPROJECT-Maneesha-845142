using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AccountServices.Models;
using AccountServices.Repositary;

namespace EmartTestProject
{
    [TestFixture]
    public class EmartTestAccountServices
    {
        AccountRepositary _repo;
        [SetUp]
        public void Setup()
        {

            _repo = new AccountRepositary(new EmartDBContext());
        }

        [Test]
        public void TestBuyerLogin()
        {
            var result = _repo.BuyerLogin("maneesha", "manu");

            Assert.IsNotNull(result);

        }
        [Test]
        public void TestSellerLogin()
        {
            var result = _repo.SellerLogin("MANU", "manu");

            Assert.IsNotNull(result);

        }
        [Test]
        public void TestBuyerRegister()
        {
            _repo.BuyerRegister(new Buyer()
            {
                BuyerId = "B21",
                UserName = "evika",
                EmailId = "devika@gmail.com",
                Password = "devika",
                MobileNo = "8453659945",
                CreatedDateTime = DateTime.Now
            });
            var result = _repo.BuyerLogin("evika", "devika");
            Assert.NotNull(result);

        }
        [Test]
        public void TestSellerRegister()
        {
            _repo.SellerRegister(new Seller()
            {

                SellerId = "S3",
                UserName = "jaga",
                EmailId = "j@gmail.com",
                Password = "jaga",
                MobileNo = "8423859745",
                CompanyName = "WE",
                Gstin = "7",
                BriefDetails = "Good",
                PostalAddress = "Chennai",
                Website = "JAGA"

            });
            var result = _repo.SellerLogin("devika", "dev");
            Assert.NotNull(result);
        }

    }
}
