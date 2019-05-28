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
    }
}
