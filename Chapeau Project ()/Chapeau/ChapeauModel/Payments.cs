using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Payments
    {
        public int orderID;
        public decimal orderPrice;
        public decimal tip;
        public decimal paidAmount;
        public string PaymentType;
        public decimal PaidAmount { get { return orderPrice + tip; } }
    }
}
