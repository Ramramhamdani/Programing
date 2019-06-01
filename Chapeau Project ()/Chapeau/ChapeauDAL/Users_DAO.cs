using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ChapeauModel;
using System.Configuration;

namespace ChapeauDAL
{
    public class Users_DAO : Base
    {
        public List<User> GetUsers()
        {
            string query = "SELECT UserName,[Password] FROM Users";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<User> ReadTables(DataTable dataTable)
        {
            List<User> users = new List<User>();
            foreach (DataRow item in dataTable.Rows)
            {
                User user = new User()
                {
                    username = (string)item["UserName"],
                    passwword = (string)item["Password"]
                };
                users.Add(user);
            }
            return users;
        }
    }
}
