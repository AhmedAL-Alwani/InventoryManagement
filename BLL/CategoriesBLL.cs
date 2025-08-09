using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.DAL;

namespace InventoryManagement.BLL
{
    class CategoriesBLL
    {
        private CategoriesDAL dal = new CategoriesDAL();

        public DataTable GetAllCategories()
        {
            return dal.GetAllCategories();
        }

        public void InsertCategory(string categoryName)
        {
            dal.InsertCategory(categoryName);
        }

        public void UpdateCategory(int categoryId, string categoryName)
        {
            dal.UpdateCategory(categoryId, categoryName);
        }

        public bool DeleteCategory(int categoryId)
        {
            if (!dal.IsCategoryUsedInItems(categoryId))
            {
                dal.DeleteCategory(categoryId);
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable SearchCategory(string searchText)
        {
            return dal.SearchCategory(searchText);
        }

    }
}
