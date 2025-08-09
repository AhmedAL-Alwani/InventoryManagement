using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using InventoryManagement.ConnectionString;

namespace InventoryManagement.DAL
{
    class ItemDAL
    {
        public DataTable GetAllItems()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = @"
                    SELECT 
                        i.Item_ID, 
                        i.Item_Name, 
                        c.Category_ID,
                        c.Category_Name, 
                        u.Unit_ID,
                        u.Unit_Name
                        FROM items i
                        JOIN Categories c ON i.Category_ID = c.Category_ID
                        JOIN Units u ON i.Unit_ID = u.Unit_ID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public void AddItem(string itemId, string itemName, int categoryId, int unitId)
        {
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "INSERT INTO items (Item_ID, Item_Name, Category_ID, Unit_ID) VALUES (@id, @name, @catId, @unitId)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", itemId);
                cmd.Parameters.AddWithValue("@name", itemName);
                cmd.Parameters.AddWithValue("@catId", categoryId);
                cmd.Parameters.AddWithValue("@unitId", unitId);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

        }

        public void UpdateItem(String itemId, string itemName, int categoryId, int unitId)
        {
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "UPDATE items SET Item_Name = @name, Category_ID = @catId, Unit_ID = @unitId WHERE Item_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", itemId);
                cmd.Parameters.AddWithValue("@name", itemName);
                cmd.Parameters.AddWithValue("@catId", categoryId);
                cmd.Parameters.AddWithValue("@unitId", unitId);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteItem(string itemId)
        {
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "DELETE FROM items WHERE Item_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", itemId);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable SearchItems(string searchText)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = @"
                SELECT 
                i.Item_ID, 
                i.Item_Name, 
                c.Category_Name, 
                u.Unit_Name
                FROM items i
                JOIN Categories c ON i.Category_ID = c.Category_ID
                JOIN Units u ON i.Unit_ID = u.Unit_ID
                WHERE 
                i.Item_Name LIKE @search OR 
                i.Item_ID LIKE @search OR 
                c.Category_Name LIKE @search OR 
                u.Unit_Name LIKE @search";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", $"%{searchText}%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "SELECT Category_ID, Category_Name FROM Categories";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable GetAllUnits()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "SELECT Unit_ID, Unit_Name FROM Units";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
        public bool IsItemUsedInTransactions(string ItemId)
        {
            bool IsUsed = false;
            string query = "SELECT COUNT(*) FROM InventoryTransactionDetails WHERE Item_ID = @id";
            SqlConnection conn = DBConnection.GetConnectionString();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", ItemId);
            try
            {
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                IsUsed = count > 0;
            }
            finally
            {
                conn.Close();
            }
            return IsUsed;
        }
    }
}

