using System;

namespace Assignment_2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            Customer customer = new Customer("Messi", 31, DateTime.Today, DateTime.Parse("24-jun-1987"));
            Customer customer2 = new Customer("Paulusma", 62, DateTime.Today, DateTime.Parse("15/dec/1956"));
            PrintCustomer(customer);
            Ticket ticket = new Ticket("Bohemian Rapsody", 1, DateTime.Parse("23/feb/2019 21:30:00"), 6,10.5);
            Reservation reservation = new Reservation(customer, ticket);
            reservation.AddTicket(ticket);
            reservation.AddTicket(ticket);
            CreatingTickets(reservation);
            Console.ReadKey();
        }
        void PrintCustomer(Customer customer)
        {
            Console.Write(customer.name + "\n" + "date of birth: {0:dd-MM-yyyy}", customer.Date);
            Console.Write("\n" + $"age: {customer.DateOfBirth}"
             + "\n" + $"date of registeration: {DateTime.Today.ToShortDateString()}"
             + "\n" + $"discount: {customer.Discount}");
            Console.WriteLine();
        }
        void CreatingTickets(Reservation reservation)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Creating tickets for {reservation.Customer.name}");
            Console.ResetColor();
            foreach (Ticket ticket in reservation.Tickets)
            {
                Console.WriteLine($"Created ticket '{ticket.MovieName}', start time: {ticket.StartTime} " +
                    $"price: {ticket.Price}, room: {ticket.CinemaRoom} ({ticket.MinimumAge}+)");
            }
            Console.WriteLine();
            Console.WriteLine($"Total price of reservation: {reservation.TotalPrice}");
        }
    }
}
