using InventoryManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.BLL
{
    class UnitsBLL
    {
        private UnitsDAL dal = new UnitsDAL();

        public DataTable GetAllUnits()
        {
            return dal.GetAllUnits();
        }
        public void AddUnit(string UnitName)
        {
            dal.AddUnit(UnitName);
        }
        public bool DeleteUnit(int unitId)
        {
            if (!dal.IsUnitUsedInItems(unitId))
            {
                dal.DeleteUnit(unitId);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpdateUnit(int UnitId , string UnitName)
        {
            dal.UpdateUnit(UnitId, UnitName);
        }
        public DataTable SearchUnit(string searchText)
        {
            return dal.SearchUnit(searchText);
        }
    }
}
