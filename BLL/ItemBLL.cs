using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.DAL;
using System.Data;

namespace InventoryManagement.BLL
{
    class ItemBLL
    {
        private ItemDAL dal = new ItemDAL();

        public DataTable GetAllItems() => dal.GetAllItems();

        public void AddItem(string itemId, string name, int catId, int unitId) => dal.AddItem(itemId, name, catId, unitId);

        public void UpdateItem(String id, string name, int catId, int unitId) => dal.UpdateItem(id, name, catId, unitId);

        public bool DeleteItem(string id)
        {
            if (!dal.IsItemUsedInTransactions(id))
            {
                dal.DeleteItem(id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable SearchItems(string text) => dal.SearchItems(text);
        public DataTable GetCategories()
        {
            return dal.GetAllCategories();
        }

        public DataTable GetUnits()
        {
            return dal.GetAllUnits();
        }

    }

}

