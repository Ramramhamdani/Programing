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
            Random rnd = new Random();
            int number = rnd.Next(0, 11);
            int factorial;
            while (number != 0)
            {
                factorial = Factorial(number);
                Console.WriteLine("fac of {0} is {1}", number, factorial);
                rnd = new Random();
                number = rnd.Next(0, 11);
            }
            Console.ReadKey();
        }
        static int Factorial(int number)
        {
            int factorial = 1;
            while (number != 0)
            {
                factorial = 0;

            }
            return factorial;
        }
    }
}
