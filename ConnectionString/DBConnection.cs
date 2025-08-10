using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.ConnectionString
{
    class DBConnection
    {
        private static string connectionString = @"Data Source=.;Initial Catalog=Inventory_DB;Integrated Security=True";
        public static SqlConnection GetConnectionString()
        {
            
            return new SqlConnection (connectionString);
        }

    }
}
