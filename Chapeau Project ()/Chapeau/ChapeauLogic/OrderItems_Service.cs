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
    public class OrderItems_Service
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
        public List<OrderItems> GetOrderItems(int lowID, int highID, int tableNumber)
        {
            try
            {
                List<OrderItems> orderItems = orderItemsDb.GetOrderItems(lowID, highID, tableNumber);
                return orderItems;
            }
            catch (SqlException e)
            {

                throw e;
            }
        }
        public List<OrderItems> GetOrderItems(int itemID)
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
        public void ChangeStatus(int status, int orderID, int lowID, int highID)
        {
            try
            {
                orderItemsDb.ChangeStatus(status, orderID, lowID, highID);

            }
            catch (SqlException e)
            {

                throw e;
            }
        }
        public List<OrderItems> GetDoneItems(int tableNr)
        {
            try
            {
                List<OrderItems> orderItems = orderItemsDb.GetDoneItems(tableNr);
                return orderItems;
            }
            catch (SqlException e)
            {

                throw e;
            }
        }
        public void AddComment(string comment, int orderID)
        {
            try
            {
                orderItemsDb.AddComment(comment, orderID);
            }
            catch (SqlException e)
            {

                throw e;
            }
        }
    }
}
