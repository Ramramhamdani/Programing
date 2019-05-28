using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class Payments_DAO : Base
    {
        public List<Payments> GetPayments()
        {
            string query = "SELECT * FROM Payments";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Payments> ReadTables(DataTable dataTable)
        {
            List<Payments> payments = new List<Payments>();
            foreach (DataRow item in dataTable.Rows)
            {
                Payments payment = new Payments()
                {
                    orderID = (int)item["OrderID"],
                    orderPrice = (decimal)item["OrderPrice"],
                    paidAmount = (decimal)item["paid amount"],
                    PaymentType = (string)item["payment type"],
                    tip = (decimal)item["tip"]
                };
                payments.Add(payment);
            }
            return payments;
        }
    }
}
