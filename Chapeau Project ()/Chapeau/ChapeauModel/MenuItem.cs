using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class MenuItem
    {
        public string Name { get { return name; } set { value = name; } }
        public int menuItemID;
        public string name;
        public decimal price;
        public int stock;
        public int CategoryID;

        public MenuItem()
        {
            
        }
        public MenuItem(string name, decimal price, int stock, int categoryID, int ID)
        {
            menuItemID = ID;
            this.name = name;
            this.price = price;
            this.stock = stock;
            CategoryID = categoryID;
        }
    }
}
