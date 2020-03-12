using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SellerServices.Models;

namespace SellerServices.Repositary
{
    public class ItemRepositary : IItemRepositary
    {
        private readonly EmartDBContext _context;
        public ItemRepositary(EmartDBContext context)
        {
            _context = context;
        }
        public void AddItem(Items iobj)
        {

            _context.Add(iobj);
            _context.SaveChanges();
        }

        public void DeleteItem(string id)
        {
            Items item = _context.Items.Find(id);
            _context.Remove(item);
            _context.SaveChanges();
        }

        public Items GetItem(string itemid)
        {
            return _context.Items.Find(itemid);
        }

        public void UpdateItem(Items obj)
        {
            // Items item = _context.Find(obj.ItemId);
            _context.Items.Update(obj);
            _context.SaveChanges();
        }

        public List<Items> ViewItems()
        {


            //return _context.Items.Where(id=>id.SellerId==sid).ToList();


            return _context.Items.ToList();

        }




        public List<Category> GetCategories()
        {
            return _context.Category.ToList();


        }


        public List<SubCategory> GetSubCategories(string catid)
        {
            return _context.SubCategory.Where(id => id.CategoryId == catid).ToList();

        }
    }
}
