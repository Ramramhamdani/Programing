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
    public class Payments_Service
    {
        Payments_DAO paymentsDb = new Payments_DAO();
        public List<Payments> GetPayments()
        {
            try
            {
                List<Payments> payments = paymentsDb.GetPayments();
                return payments;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public void AddPayment(Payments payment)
        {
            try
            {
                paymentsDb.AddPayment(payment);
            }
            catch (SqlException e)
            {

                throw e;
            }
        }
    }
}
