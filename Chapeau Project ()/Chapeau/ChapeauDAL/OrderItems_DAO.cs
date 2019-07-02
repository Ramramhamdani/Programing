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
        public List<OrderItems> GetOrderItems(int itemID)
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
                    amount = (int)item["amount"],
                    status = (int)item["status"]
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
        public List<OrderItems> GetOrderItems(int lowID, int highID, int tableNumber)
        {
            string query = $"SELECT OrderItems.* FROM OrderItems " +
                $"INNER JOIN [Order] AS O ON orderItems.OrderID = O.OrderID " +
                $"WHERE (MenuItemID BETWEEN {lowID} AND {highID}) AND O.TableID = {tableNumber} AND OrderItems.[status] = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItems> WriteOrderItems()
        {
            string query = "SELECT * FROM OrderItems";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItems> WriteTables(DataTable dataTable)
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
                    amount = (int)item["amount"],
                    status = (int)item["status"]
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
        public void ChangeStatus(int status, int orderID,int lowID, int highID)
        {
            //28 => 48 Drinks
            //0=ordered, 1= done, 3= served
            string query = $"UPDATE [OrderItems] SET [status] = {status} " +
                $"WHERE OrderID = {orderID} AND MenuItemID BETWEEN {lowID} AND {highID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<OrderItems> GetDoneItems(int tableNr)
        {
            string query = $"SELECT OrderItems.*, M.[name], C.MenuCategoryID,(M.price * C.VAT / 100) as [VAT] " +
                $"FROM OrderItems " +
                $"INNER JOIN[Order] AS O ON orderItems.OrderID = O.OrderID " +
                $"INNER JOIN[MenuItem] AS M ON OrderItems.MenuItemID = M.MenuItemID " +
                $"INNER JOIN MenuCategory AS C ON M.CategoryID = C.MenuCategoryID " +
                $"WHERE((M.CategoryID BETWEEN 1 AND 48) AND O.TableID = {tableNr}) AND OrderItems.[status] = 2";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddComment(string comment, int orderID)
        {
            string query = $"UPDATE OrderItems SET comments = '{comment}' WHERE OrderID = 3";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
