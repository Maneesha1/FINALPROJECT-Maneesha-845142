using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SellerServices.Models;
using SellerServices.Repositary;

namespace EmartTestProject
{
    [TestFixture]
    public class EmartTestSellerService
    {
        SellerRepositary _repo;
        [SetUp]
        public void Setup()
        {

            _repo = new SellerRepositary(new EmartDBContext());
        }
        [Test]
        public void TestGetProfile()
        {
            var result = _repo.GetProfile("1");
            Assert.IsNotNull(result);

        }
        [Test]
        public void TestEditProfile()
        {

            Seller item = _repo.GetProfile("1");
            item.MobileNo = "945937723";
            _repo.EditProfile(item);
            Seller item1 = _repo.GetProfile("1");
            Assert.AreSame(item, item1);
        }


    }
}
