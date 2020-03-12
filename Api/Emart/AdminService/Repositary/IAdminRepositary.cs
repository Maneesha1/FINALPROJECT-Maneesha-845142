using System.Collections.Generic;
using AdminService.Models;

namespace AdminService.Repositary
{
    public interface IAdminRepositary
    {
        public void AddCategories(Category catobj);
        public void AddSubCategories(SubCategory subcatobj);
        List<Category> ViewCategories();
        List<SubCategory> ViewSubCategories();
        public void EditCategories(Category catobj);
        public void EditSubCategories(SubCategory subcatobj);
        public void DeleteCategories(string catid);

        public void DeleteSubCategories(string subcatid);
        public Category GetCatById(string catid);
        public SubCategory GetSubCatById(string subcatid);

    }

}
