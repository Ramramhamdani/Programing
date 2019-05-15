using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Reservation
    {
        public Customer Customer { get; set; }
        private List<Ticket> tickets = new List<Ticket>();
        public List<Ticket> Tickets { get { return tickets; } set { tickets = value; } }
        private double totalPrice;
        public double TotalPrice
        {
            get
            {
                foreach (Ticket ticket in Tickets)
                {
                    if (ticket.Discount == true)
                    {
                        totalPrice = totalPrice + (((double)ticket.Price * 10) / 100);
                    }
                    else
                    {
                        totalPrice = totalPrice + (double)ticket.Price;
                    }
                }
                if ((DateTime.Today.Year > Customer.date.Year) && (DateTime.Today.Month > Customer.date.Month))
                {
                    totalPrice += ((totalPrice * 10) / 100);
                }
                return totalPrice;
            }
            set { totalPrice = value; }
        }
        public Reservation(Customer customer, Ticket ticket)
        {
            Customer = customer;
            Tickets.Add(ticket);
        }
        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
    }
}
