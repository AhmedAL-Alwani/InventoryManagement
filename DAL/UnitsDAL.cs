using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using InventoryManagement.ConnectionString;

namespace InventoryManagement.DAL
{
    class UnitsDAL
    {
        public DataTable GetAllUnits()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "SELECT Unit_ID, Unit_Name FROM Units";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            finally
            {
                conn.Close();

            }
            return dt;
        }
        public void AddUnit(string UnitName)
        {
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "INSERT INTO Units (Unit_Name) VALUES (@name)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", UnitName);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void DeleteUnit(int UnitId)
        {
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "DELETE FROM Units WHERE Unit_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", UnitId);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void UpdateUnit(int UnitId ,string UnitName)
        {
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "UPDATE Units SET Unit_Name = @name WHERE Unit_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", UnitName);
                cmd.Parameters.AddWithValue("@id", UnitId);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable SearchUnit(string searchText)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConnection.GetConnectionString();
            try
            {
                conn.Open();
                string query = "SELECT Unit_ID, Unit_Name FROM Units WHERE Unit_Name LIKE @search";
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
        public bool IsUnitUsedInItems(int unitId)
        {
            bool IsUsed = false;
            string query = "SELECT COUNT(*) FROM Items WHERE Unit_ID = @id";
            SqlConnection conn = DBConnection.GetConnectionString();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", unitId);

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
