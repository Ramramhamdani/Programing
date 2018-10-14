using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number(0 is stop value): ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
           
            while (number != 0)
            {
                IsPrime = Prime(number);
                if (IsPrime&& number!=1)
                {
                    Console.WriteLine("{0} is a prime number.", number);
                }
                else if (number==1)
                {
                    Console.WriteLine("{0} is not a prime number.", number);
                }
                else
                {
                    Console.WriteLine("{0} is not a prime number.", number);
                }
                Console.Write("Enter a number(0 is stop value): ");
                number = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("End of program");
            Console.ReadKey();
        }
        static bool Prime(int input)
        {
            bool IsPrime = true;
            int i = 2;
            while (i<input && IsPrime)
            {
                if ((input%i)==0)
                {
                    IsPrime = false;
                }
                else if (input==1)
                {
                    IsPrime = false;
                }
                else
                {
                    i = i + 1;
                }

            }
            return IsPrime;
        }
    }
}
