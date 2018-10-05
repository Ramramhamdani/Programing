using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;

            while (input!=0)
            {
                
                
                    count++;

                    if (count % 5 == 0)
                    {
                    //if the order of the number divideble by 5 add it to the sum
                        sum = sum + input;
                    }
                
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("sum of 5th, 10th, 15th, etc...number is: {0}", sum);
            Console.ReadKey();
        }   
    }
}
