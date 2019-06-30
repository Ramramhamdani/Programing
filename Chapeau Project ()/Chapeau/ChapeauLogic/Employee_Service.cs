using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauLogic
{
    public class Employee_Service
    {
        Employee_DAO employeeDb = new Employee_DAO();

        public List<Employee> GetEmployees()
        {
            try
            {
                List<Employee> employees = employeeDb.GetEmployees();
                return employees;
            }
            catch (Exception e)
            {                
                throw e;
            }
        }
    }
}
