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
    public class order_Service
    {
        Order_DAO orderDb = new Order_DAO();
        public List<Order> GetOrders()
        {
            try
            {
                List<Order> orders = orderDb.GetOrders();
                return orders;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
