using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());
            // if the remainder is zero, the numbers are multiple for each other
            if (first%second==0)
            {
                Console.WriteLine("Number {0} is multiple of {1}", first, second);
            }
            else if (second%first==0)
            {
                Console.WriteLine("Number {0} is multiple of {1}", second, first);
            }
            else
            {
                Console.WriteLine("Numbers are no multiples");
            }
            Console.ReadKey();


        }
    }
}
