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
    public class MenuItem_Service
    {
        MenuItem_DAO MenuItemDb = new MenuItem_DAO();
        public List<MenuItem> GetMenuItems(int categoryID)
        {
            try
            {
                List<MenuItem> menuItems = MenuItemDb.GetMenuItems(categoryID);
                return menuItems;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<MenuItem> GetItems(int lowID, int highID, int tableNumber)
        {
            try
            {
                List<MenuItem> menuItems = MenuItemDb.GetItems(lowID, highID, tableNumber);
                return menuItems;
            }
            catch (SqlException e)
            {

                throw e;
            }
        }
        
        public List<MenuItem> GetLunchItems()
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
