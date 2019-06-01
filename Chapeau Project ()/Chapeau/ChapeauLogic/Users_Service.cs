using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class Users_Service
    {
        Users_DAO UsersDb = new Users_DAO();

        public List<User> GetUsers()
        {
            try
            {
                List<User> users = UsersDb.GetUsers();
                return users;
            }
            catch (SqlException e)
            {

                throw e;
            }
        }
    }
}
