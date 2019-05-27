using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    class MenuItem_Service
    {
        MenuItem_DAO MenuItemDb = new MenuItem_DAO();
        public List<MenuItem> GetMenuItems()
        {
            try
            {
                List<MenuItem> menuItems = MenuItemDb.GetMenuItems();
                return menuItems;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
