using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your year of birth: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            int birthday = currentYear - year;
            if (birthday == age)
            {
                Console.WriteLine("Hi {0}, you already had your birthday this year!", name);
            }
            else if (age == birthday - 1)
            {
                Console.WriteLine("Hi {0}, your birthday will be later this year!", name);
            }
            else
            {
                Console.WriteLine("Hi {0}, the entered age or year of birth is incorrect!", name);
            }
            Console.ReadKey();
        }
    }
}
