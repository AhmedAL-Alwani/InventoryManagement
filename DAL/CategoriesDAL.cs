using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.ConnectionString;

namespace InventoryManagement.DAL
{
    class CategoriesDAL
    {
        public DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "SELECT Category_ID, Category_Name FROM Categories";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public void InsertCategory(string categoryName)
        {
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "INSERT INTO Categories (Category_Name) VALUES (@name)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", categoryName);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateCategory(int categoryId, string categoryName)
        {
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "UPDATE Categories SET Category_Name = @name WHERE Category_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", categoryName);
                cmd.Parameters.AddWithValue("@id", categoryId);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteCategory(int categoryId)
        {
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "DELETE FROM Categories WHERE Category_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", categoryId);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable SearchCategory(string searchText)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "SELECT Category_ID, Category_Name FROM Categories WHERE Category_Name LIKE @search";
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
        public bool IsCategoryUsedInItems(int categoryId)
        {
            bool IsUsed = false;
            string query = "SELECT COUNT(*) FROM Items WHERE Category_ID = @id";
            SqlConnection conn = DBConnection.GetConnectionString();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", categoryId);

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
