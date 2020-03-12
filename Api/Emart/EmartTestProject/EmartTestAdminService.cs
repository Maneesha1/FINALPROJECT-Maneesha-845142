using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AdminService.Models;
using AdminService.Repositary;

namespace EmartTestProject
{
    [TestFixture]
     public class EmartTestAdminService
    {
       AdminRepositary _repo;

        [SetUp]
        public void SetUp()
        {
            _repo = new AdminRepositary(new EmartDBContext());
        }

        [Test]
        [Description("Test AddCategories()")]
        public void TestAddCategories()
        {
            _repo.AddCategories(new Category()
            {
                CategoryId = "C1",
                CategoryName = "Pens",
                BriefDetails = "Types of Pens"
            });

            var result = _repo.GetCatById("C1");
            Assert.IsNotNull(result);
        }

        [Test]
        [Description("Test AddSubCategories()")]
        public void TestAddSubCategories()
        {
            _repo.AddSubCategories(new SubCategory()
            {
                SubcategoryId = "S5",
                SubcategoryName = "Pencil",
                CategoryId = "C1",
                BriefDetails = "Types of Pencilss",
                Gst = "9"
            });

            var result = _repo.GetSubCatById("S5");
            Assert.IsNotNull(result);
        }

        
        [Test]
        [Description("TestViewCategories()")]
        public void TestViewCategories()
        {
            var result = _repo.ViewCategories();
            Assert.IsNotNull(result);
        }

        [Test]
        [Description("TestViewSubCategories()")]
        public void TestViewSubCategories()
        {
            var result = _repo.ViewSubCategories();
            Assert.IsNotNull(result);
        }

        [Test]
        [Description("Test EditCategories()")]
        public void TestEditCategories()
        {
            Category item = _repo.GetCatById("1");
            item.CategoryName = "Watch";
            _repo.EditCategories(item);
            Category item1 = _repo.GetCatById("1");
            Assert.AreSame(item, item1);
            //_repo.EditCategories(new Category
            //{
            //    CategoryId = "C571",
            //    CategoryName = "Books",
            //    BriefDetails = "Differnt Books"
            //});

            //var result = _repo.GetCatById("C571");
            //Assert.IsNotNull(result);
        }

        [Test]
        [Description("Test EditSubCategories()")]
        public void TestEditSubCategories()
        {
            _repo.EditSubCategories(new SubCategory
            {
                SubcategoryId = "51",
                SubcategoryName = "Lepakshi Books",
                CategoryId = "51",
                BriefDetails = "Types of Bookss",
                Gst = "9"
            });

            var result = _repo.GetSubCatById("51");
            Assert.IsNotNull(result);
        }


        [Test]
        [Description("Test DeleteSubCategories()")]
        public void TestDeleteSubCategories()
        {
            _repo.DeleteSubCategories("S5");

            var result = _repo.GetSubCatById("S5");
            Assert.IsNull(result);
        }

        [Test]
        [Description("Test DeleteCategories()")]
        public void TestDeleteCategories()
        {
            _repo.DeleteCategories("C1");

            var result = _repo.GetCatById("C1");
            Assert.IsNull(result);
        }
    }
}


    