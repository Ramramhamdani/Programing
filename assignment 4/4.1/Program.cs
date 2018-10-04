using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            Double input = Double.Parse(Console.ReadLine());
            Double add = 0;
            int num = 0;
            
            if (input == 0)
            {
                Console.WriteLine("average of all positive nambers is: 0.00");
            }
            // while doesn't start if the input = 0 
            else
            {
                while (input != 0)
                {

                    if (input >= 0)
                    {
                        num++;
                        add = add + input;
                    }
                    Console.Write("Enter a number: ");
                    input = double.Parse(Console.ReadLine());

                }
                /* test part for the program to know how many positive nambers are there and the sum
                Console.WriteLine("num:{0} add:{1}", num, add);
                */
                Double ave = add / num;
                Console.WriteLine("Average of all positive numbers is: {0:0.00}", ave);
            }
            Console.ReadKey();
        }
    }
}
