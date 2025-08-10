using InventoryManagement.ConnectionString;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAL
{
    class TransactionsRepoDAL
    {
        public DataTable GetAllTypeTransactions()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "SELECT TransactionType_ID, TransactionType_Name FROM TransactionTypes";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr["TransactionType_ID"] = DBNull.Value;
                dr["TransactionType_Name"] = "الكل";
                dt.Rows.InsertAt(dr, 0);
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
        public DataTable GetAllItem()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "SELECT Item_ID, Item_Name FROM Items";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr["Item_ID"] = DBNull.Value;
                dr["Item_Name"] = "الكل";
                dt.Rows.InsertAt(dr, 0);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
