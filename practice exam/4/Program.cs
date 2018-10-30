using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //generating a number alwayes outside the loop
            Random rnd = new Random();
            int number = 1;
            while (number != 0)
            {
                number = rnd.Next(0, 11);

                if (number != 0)
                {
                    int fac = Factorial(number);
                    Console.WriteLine("Factorial of {0} is {1}", number, fac);
                }

            }
            Console.WriteLine("end of program");
            Console.ReadKey();
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
