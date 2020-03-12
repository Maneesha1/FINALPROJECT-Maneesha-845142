using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SellerServices.Models;
using SellerServices.Repositary;

namespace EmartTestProject
{
    [TestFixture]
    public class EmartTestItemService
    {
        ItemRepositary _repo;
        [SetUp]
        public void Setup()
        {

            _repo = new ItemRepositary(new EmartDBContext());
        }
        [Test]
        public void TestAddItem()
        {
            _repo.AddItem(new Items()

            {
                SellerId = "1",
                ItemId = "I8",
                CategoryId = "1",
                SubcategoryId = "2",
                Price = "3545",
                ItemName = "icecream",
                Image = "e2.jpg",
                Description = "Good",
                StockNumber = "233",
                Remarks = "Super"


            });
        }
        [Test]
        public void TestViewItems()
        {
            var result = _repo.ViewItems();
            Assert.GreaterOrEqual(result.Count, 3);
            // Assert.IsNotNull(result);
        }
        [Test]
        [Description("Test DeleteItems()")]
        public void TestDeleteItem()
        {
            _repo.DeleteItem("I8");

            var result = _repo.GetItem("I8");
            Assert.IsNull(result);
        }
        [Test]
        public void TestUpdateItem()
        {
            _repo.UpdateItem(new Items
            {
              
               ItemId="I9",
               CategoryId="1",
               SubcategoryId="2",
               SellerId="1",
               StockNumber="140",               
               ItemName="Icecream",
               Price="345",
               Description="Good",
               Remarks="Good",
               Image="e3.png"
            });

            var result = _repo.GetItem("I9");
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetSubCategories()
        {
            var result = _repo.GetSubCategories("1");
            // Assert.GreaterOrEqual(result.Count, 6);
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetCategories()
        {
            var result = _repo.GetCategories();
            // Assert.GreaterOrEqual(result.Count, 6);
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestGetItem()
        {
            var result = _repo.GetItem("I9");
            // Assert.GreaterOrEqual(result.Count, 6);
            Assert.IsNotNull(result);
        }



    }
}
