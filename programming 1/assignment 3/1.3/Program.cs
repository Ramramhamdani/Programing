using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter third number:");
            int third = int.Parse(Console.ReadLine());

            
            if (third<first && third<second)
                {
                Console.WriteLine("the third number is the smallest of the three");

                }
            else  
            {
                Console.WriteLine("the third number is not the smallest of three ");
            }

            Console.ReadKey();
        }    
    }
}
