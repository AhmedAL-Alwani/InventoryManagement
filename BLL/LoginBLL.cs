using InventoryManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.BLL
{
    class LoginBLL
    {
        LoginDAL userDAL = new LoginDAL();

        public int Login(string username, string password)
        {
            return userDAL.CheckLogin(username, password);
        }

    }
}
