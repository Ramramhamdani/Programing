using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Random rnd = new Random();
            int number = rnd.Next(0, 11);
            int factorial;
            while (number != 0)
            {

                number = rnd.Next(0, 11);
                if (number != 0)
                {
                    factorial = Factorial(number);
                    Console.WriteLine("fac of {0} is {1}", number, factorial);
                }

            }
            Console.ReadKey();
            goto start;
        }
        static int Factorial(int number)
        {
            int factorial = 1;
            while (number != 0)
            {
                factorial = factorial * number;
                number--;

            }
            return factorial;
        }
    }
}
