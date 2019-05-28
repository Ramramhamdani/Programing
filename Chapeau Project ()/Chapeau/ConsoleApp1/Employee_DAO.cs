using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class Employee_DAO : Base
    {
        public List<Employee> GetEmployees()
        {
            string query = "SELECT * FROM Employee";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow item in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    employeeID = (int)item["EmployeeID"],
                    name = (string)item["Name"],
                    task = (string)item["task"]
                };
                employees.Add(employee);
            }
            return employees;
        }
    }
}
