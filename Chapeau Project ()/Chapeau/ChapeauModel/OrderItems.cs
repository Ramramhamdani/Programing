using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderItems
    {
        public int orderItemID;
        public int OrderID;
        public int MenuItemID;
        public int amount;
        public DateTime dateTime;
        public string comments;
        public int status;
    }
}
