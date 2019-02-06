using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //"target" is the variable of the target number 
            Console.Write("Enter target number: ");
            int target = int.Parse(Console.ReadLine());

            int count = 0;
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            while(input !=0)
            {
                //if the input equals the target number the loop counts 
                if (input==target)
                {
                    count++;
                }
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("count of numbers equal to target number: {0}", count);
            Console.ReadKey();

        }
    }
}
