using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SellerServices.Models;

namespace SellerServices.Repositary
{
    public interface IItemRepositary
    {
        void AddItem(Items itemobj);

        List<Items> ViewItems();

        void DeleteItem(string itemid);

        void UpdateItem(Items itemobj);

        Items GetItem(string itemid);

        List<Category> GetCategories();
        List<SubCategory> GetSubCategories(string catid);


    }
}
