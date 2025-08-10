using InventoryManagement.ConnectionString;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAL
{
    class LoginDAL
    {
        private SqlConnection con = DBConnection.GetConnectionString();

        public int CheckLogin(string username, string password)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT User_Id FROM Users WHERE User_Name = @uname AND User_Pass = @pass", con);
            cmd.Parameters.AddWithValue("@uname", username);
            cmd.Parameters.AddWithValue("@pass", password);

            object result = cmd.ExecuteScalar();
            con.Close();

            if (result != null)
                return Convert.ToInt32(result);
                return -1;
        }

    }
}
