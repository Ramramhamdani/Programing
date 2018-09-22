using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number:");
            int first= int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            int second= int.Parse( Console.ReadLine());
            int big;
            int small;
            if (first>second)
                {
                 big = first;
                 small = second;
                
                }
            else
                {
                 big = second;
                 small = first;
                }
            Console.WriteLine("Highest value is: {0} ",big);
            Console.WriteLine("lowest value is: {0}", small);
            Console.ReadKey();

            
        }
    }
}
