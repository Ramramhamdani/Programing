using System;
namespace Assignment_1
{


    public class Customer
    {
        private int id;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Fullname { get => FirstName + " " + LastName; }

        public Customer(int id, string firstname, string lastname, string emailAddress)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            EmailAddress = emailAddress;
        }

        public override string ToString()
        {
            Console.Write($"{Id}, {Fullname}, {EmailAddress}");
            return base.ToString();
        }
    }


}
