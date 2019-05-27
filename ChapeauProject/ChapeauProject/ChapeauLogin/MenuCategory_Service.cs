using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    class MenuCategory_Service
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
