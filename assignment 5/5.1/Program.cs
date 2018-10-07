using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Double sum = 0;
            Double diff = 0;
            int num = 0;
            int count = 0;
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 200);
            }
            foreach (int number in numbers)
            {

                Console.WriteLine("Element {0} is {1}", count, number);
                count++;
                sum = sum + number;
            }
            Double ave = sum / 20;
            Console.WriteLine();
            Console.WriteLine("The average is:" + ave);
            Console.WriteLine();
            foreach (int item in numbers)
            {

                diff = ave - item;
                Console.WriteLine("the difference between the average and element {0} is {1:0.00}", num, Math.Abs(diff));
                num++;
            }

            Console.ReadKey();
        }
    }
}
