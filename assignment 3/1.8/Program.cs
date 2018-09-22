using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of working hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter number of years: ");
            int years = int.Parse(Console.ReadLine());
            Console.Write("Enter number of failures: ");
            int fail = int.Parse(Console.ReadLine());

            if (hours<=10000 && years<=7 && fail<=25)
            {
                Console.WriteLine("Machine does not need to be replaced.");
            }
            else
            {
                Console.WriteLine("machine need to be replaced.");

            }
            Console.ReadKey();
           
        }
    }
}
