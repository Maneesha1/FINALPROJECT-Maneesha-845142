using System;
using System.Collections.Generic;
using System.Text;
using BuyerService.Models;
using BuyerService.Repositary;
using NUnit.Framework;

namespace EmartTestProject
{
    [TestFixture]
    public class EmartTestBuyerService
    {
        BuyerRepositary _repo;
        [SetUp]
        public void Setup()
        {

            _repo = new BuyerRepositary(new EmartDBContext());
        }
        [Test]
        public void TestSearchItems()
        {
            var result = _repo.SearchItems("fguj");
            //Assert.GreaterOrEqual(result.Count, 5);
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestBuyItem()
        {
            _repo.BuyItem(new Transactionhistory()
            {
                
                BuyerId = "2",
                SellerId = "1",
                TransactionId = "4",
                ItemId = "I518",
                NumberOfItems = "2",
                DateTime = DateTime.Now,
                
                TransactionType = "card"
            });
            var result = _repo.SearchItems("1");
            Assert.NotNull(result);

        }
        [Test]
        public void TestEditProfile()
        {

            Buyer item = _repo.ViewProfile("1");
            item.MobileNo = "945937723";
            _repo.EditProfile(item);
            Buyer item1 = _repo.ViewProfile("1");
            Assert.AreSame(item, item1);
        }
        [Test]
        public void TestViewProfile()
        {
            var result = _repo.ViewProfile("1");
            Assert.IsNotNull(result);

        }
        [Test]
        public void TestTransactionHistory()
        {
            var result = _repo.Transactionhistory("1");
            //Assert.GreaterOrEqual(result.Count, 5);
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetCategories()
        {
            var result = _repo.GetCategories();
            Assert.GreaterOrEqual(result.Count, 6);
            // Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetSubCategories()
        {
            var result = _repo.GetSubCategories("1");
            // Assert.GreaterOrEqual(result.Count, 6);
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestAddtocart()
        {
            _repo.Addtocart(new Cart()
            {
                CartId = "5",
                CategoryId = "1",
                SubcategoryId = "2",
                SellerId = "1",
                BuyerId="1",
                ItemId = "I9",
                Itemname = "asd",
                Price = "345",
                Description = "Good",
                //Remarks="sdls",
                Image = "e3.png"
            });
            var result = _repo.ViewCart("1");
            Assert.NotNull(result);

        }
        [Test]
        public void TestDeleteFromCart()
        {
            _repo.Deletefromcart("5");
            var result = _repo.ViewCart("1");
            Assert.IsNotNull(result);

        }
        [Test]
        public void TestViewCart()
        {
            var result = _repo.ViewCart("1");
            Assert.IsNotNull(result);

        }

    }
}
