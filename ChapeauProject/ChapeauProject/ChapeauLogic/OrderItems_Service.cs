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
    class OrderItems_Service
    {
        OrderItems_DAO orderItemsDb = new OrderItems_DAO();
        public List<OrderItems> GetOrderItems()
        {
            try
            {
                List<OrderItems> orderItems = orderItemsDb.GetOrderItems();
                return orderItems;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
