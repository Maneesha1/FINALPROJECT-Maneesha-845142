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
            var result = _repo.BuyerLogin("manee", "manu");

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
                BuyerId = "121",
                UserName = "das",
                EmailId = "des@gmail.com",
                Password = "des",
                MobileNo = "8453657745",
                CreatedDateTime = DateTime.Now
            });
            var result = _repo.BuyerLogin("devika", "dev");
            Assert.NotNull(result);

        }
        [Test]
        public void TestSellerRegister()
        {
            _repo.SellerRegister(new Seller()
            {

                SellerId = "13",
                UserName = "deika",
                EmailId = "d@gmail.com",
                Password = "deav",
                MobileNo = "8423957745",
                CompanyName = "QWE",
                Gstin = "4",
                BriefDetails = "Good",
                PostalAddress = "Chennai",
                Website = "DAS"

            });
            var result = _repo.SellerLogin("devika", "dev");
            Assert.NotNull(result);
        }

    }
}
