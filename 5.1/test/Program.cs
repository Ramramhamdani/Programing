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
            int[] numbers = new int[20];
            int count = 0;
            Double sum = 0;
            int ele = 0;
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 200);
            }
            foreach (int number in numbers)
            {
                
                Console.WriteLine("Element {0} is {1}",count, number);
                count++;
                sum = sum + number;
            }
            Double ave = sum / 20;
            Console.WriteLine();
            Console.WriteLine("The average is: {0}", ave);
            Console.WriteLine();
            foreach (int number in numbers)
            {
                
                Double dif = ave - number;
                Console.WriteLine("the diffrence between the element {0} and the average is {1}", ele, Math.Abs(dif));
                    ele++;
            }



            Console.ReadKey();
               
            
        }
    }
}
