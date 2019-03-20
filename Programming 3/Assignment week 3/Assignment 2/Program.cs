using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Customer customer = new Customer("Messi", 31, DateTime.Today, DateTime.Parse("24-06-1987"));
            Customer customer2 = new Customer("Paulusma", 62, DateTime.Today, DateTime.Parse("15/12/1956"));
            PrintCustomer(customer);
            Console.ReadKey();
        }
        void PrintCustomer(Customer customer)
        {
            Console.Write(customer.name + "\n" + $"date of birth: {customer.DateOfBirth}"
                + "\n" + $"age: {customer.age}"
                + "\n" + $"date of registeration: {DateTime.Today.ToShortDateString()}" 
                + "\n" + $"discount: {customer.Discount}");
        }
    }
}
