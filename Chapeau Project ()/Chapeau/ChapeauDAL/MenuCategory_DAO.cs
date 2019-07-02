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
    public class MenuCategory_DAO : Base
    {
        public List<MenuCategory> GetMenuCategories()
        {
            string query = "SELECT * FROM MenuCategory";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<MenuCategory> ReadTables(DataTable dataTable)
        {
            List<MenuCategory> menuCategories = new List<MenuCategory>();
            foreach (DataRow item in dataTable.Rows)
            {
                MenuCategory menuCategory = new MenuCategory()
                {
                    menuCategoryID = (int)item["MenuCategoryID"],
                    name = (string)item["name"],
                    VAT = (decimal)item["VAT"]
                };
                menuCategories.Add(menuCategory);
            }
            return menuCategories;
        }
        public List<MenuCategory> GetVAT(int tableNr)
        {
            string query = $"SELECT OrderItems.*, M.[name], C.MenuCategoryID,(M.price*C.VAT/100) as [VAT] " +
                $"FROM OrderItems " +
                $"INNER JOIN[Order] AS O ON orderItems.OrderID = O.OrderID " +
                $"INNER JOIN[MenuItem] AS M ON OrderItems.MenuItemID = M.MenuItemID " +
                $"INNER JOIN MenuCategory AS C ON M.CategoryID = C.MenuCategoryID " +
                $"WHERE((M.CategoryID BETWEEN 1 AND 48) AND O.TableID = {tableNr}) AND OrderItems.[status] = 2";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        
    }
}
