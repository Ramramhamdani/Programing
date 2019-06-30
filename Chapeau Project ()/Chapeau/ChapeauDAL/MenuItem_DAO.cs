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
    public class MenuItem_DAO : Base
    {
        public List<MenuItem> GetMenuItems()
        {
            string query = "SELECT * FROM MenuItem where MenuItemID <> 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            foreach (DataRow item in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    menuItemID = (int)item["MenuItemID"],
                    name = (string)item["name"],
                    price = (decimal)item["price"],
                    stock = (int)item["stock"],
                    CategoryID = (int)item["CategoryID"]
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }                     
        public List<MenuItem> GetMenuItems(int categoryID)
        {
            string query = $"SELECT * FROM MenuItem WHERE (CategoryID = {categoryID})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItemTables(ExecuteSelectQuery(query, sqlParameters));
        }
        
        private List<MenuItem> ReadItemTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            foreach (DataRow item in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    menuItemID = (int)item["MenuItemID"],
                    name = (string)item["name"],
                    price = (decimal)item["price"],
                    stock = (int)item["stock"],
                    CategoryID = (int)item["CategoryID"]
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }
        public List<MenuItem> GetItems(int lowID,int highID,int tableNumber)
        {
            // Status = 0 = orderd || status = 1 = served
            string query = $"SELECT OrderItems.*, M.* FROM OrderItems " +
                $"INNER JOIN [Order] AS O ON orderItems.OrderID = O.OrderID  " +
                $"INNER JOIN [MenuItem] AS M ON OrderItems.MenuItemID = M.MenuItemID " +
                $"WHERE ((M.CategoryID BETWEEN {lowID} AND {highID}) AND O.TableID = {tableNumber}) AND OrderItems.[status] = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        
    }
}
