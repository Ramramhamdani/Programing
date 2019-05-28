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
    public class MenuICategory_Service
    {
        MenuCategory_DAO MenuCategoryDb = new MenuCategory_DAO();
        public List<MenuCategory> GetCategories()
        {
            try
            {
                List<MenuCategory> menuCategories = MenuCategoryDb.GetMenuCategories();
                return menuCategories;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
