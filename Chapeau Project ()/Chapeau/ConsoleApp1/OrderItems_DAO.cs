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
    public class OrderItems_DAO : Base
    {
        public List<OrderItems> GetOrderItems()
        {
            string query = "SELECT * FROM OrderItems";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItems> ReadTables(DataTable dataTable)
        {
            List<OrderItems> orderItems = new List<OrderItems>();
            foreach (DataRow item in dataTable.Rows)
            {
                OrderItems orderItem = new OrderItems()
                {
                    orderItemID = (int)item["OrderItemID"],
                    OrderID = (int)item["OrderID"],
                    MenuItemID = (int)item["MenuItemID"],
                    dateTime = (DateTime)item["Date/Time"],
                    comments = (string)item["comments"],
                    amount = (int)item["amount"]
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
    }
}
