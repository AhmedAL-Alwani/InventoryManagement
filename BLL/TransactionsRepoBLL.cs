using InventoryManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.BLL
{
    class TransactionsRepoBLL
    {
        private TransactionsRepoDAL dal = new TransactionsRepoDAL();
            public DataTable GetAllTypeTransactions() => dal.GetAllTypeTransactions();
            public DataTable GetAllItem() => dal.GetAllItem();
    }

}
