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
            string query = "SELECT UserName,[Password],EmployeeID FROM Users";
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
                    username = (string)item["Username"],
                    passwword = (string)item["Password"],
                    ID = (int)item["EmployeeID"]
                };
                users.Add(user);
            }
            return users;
        }
        public string GetTask(User user)
        {
            string query = $"SELECT E.task as [type] FROM Users as u " +
                $" inner join Employee as E ON u.EmployeeID = E.EmployeeID WHERE u.EmployeeID = {user.ID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTask(ExecuteSelectQuery(query, sqlParameters));
        }
        private string ReadTask(DataTable dataTable)
        {
            string type = "";
            foreach (DataRow item in dataTable.Rows)
            {

                type = (string)item["type"];
                
            }
            return type;
        }
    }
}
