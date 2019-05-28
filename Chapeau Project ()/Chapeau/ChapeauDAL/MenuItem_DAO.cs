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
            string query = "SELECT * FROM MenuItem";
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
    }
}
