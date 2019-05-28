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
    public class Order_DAO : Base
    {
        public List<Order> GetOrders()
        {
            string query = "SELECT * FROM Order";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            foreach (DataRow item in dataTable.Rows)
            {
                Order order = new Order()
                {
                    orderID = (int)item["OrderID"],
                    employeeID = (int)item["EmployeeID"],
                    tableID = (int)item["TableID"],
                    feedback = (string)item["feedback"]
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
