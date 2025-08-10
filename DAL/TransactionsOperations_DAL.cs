using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Web.Util;
using System.Windows.Forms;
using InventoryManagement.ConnectionString;
using InventoryManagement.MyForms.UserControls;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace InventoryManagement.DAL
{
    public class TransactionsOperations_DAL
    {

        public class Header
        {
            public DataTable GetAllHeader()
            {
                DataTable dt = new DataTable();
                string query = "SELECT Transaction_ID, TransactionDate, Supplier_ID, Null, User_ID FROM InventoryTransactions";
                using (SqlConnection conn = DBConnection.GetConnectionString())
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }

                return dt;
            }

            public List<string> GetSuppliersList()
            {
                List<string> suppliers = new List<string>();

                string query = "SELECT Suppliers.Supplier_Name FROM InventoryTransactions RIGHT OUTER JOIN Suppliers ON InventoryTransactions.Supplier_ID = Suppliers.Supplier_ID";

                using (SqlConnection conn = DBConnection.GetConnectionString())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // نحول كل صف في الجدول إلى عنصر في القائمة
                    foreach (DataRow row in dt.Rows)
                    {
                        suppliers.Add(row["Supplier_Name"].ToString());
                    }
                }

                return suppliers;
            }

        }

        public class Body
        {
            public DataTable GetAllBody()
            {
                DataTable dt = new DataTable();
                string query = "SELECT Detail_ID ,Transaction_ID, Item_ID, Quantity, ExpiryDate FROM InventoryTransactionDetails";
                using (SqlConnection conn = DBConnection.GetConnectionString())
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }

                return dt;
            }

           


        }









    }
}
