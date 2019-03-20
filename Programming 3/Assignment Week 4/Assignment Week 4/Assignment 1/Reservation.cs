using System;
namespace Assignment_1
{



    public class Reservation
    {
        private int id;

        public Book Book { get; set; }
        public Customer Customer { get; set; }
        public int Id { get; set; }
        public DateTime RservationDateTime { get; set; }

        public Reservation(int id, Customer customer, Book book)
        {
            Id = id;
            Customer = customer;
            Book = book;
        }
        public override string ToString()
        {
            Console.Write($"[{Id}], Custemer: {Customer},Book: {Book}");
            return base.ToString();
        }
    }


}
