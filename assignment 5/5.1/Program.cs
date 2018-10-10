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
                //fill the array with random numbers
                numbers[i] = rnd.Next(0, 200);
            }
            foreach (int number in numbers)
            {
                //print each number in the array
                Console.WriteLine("Element {0} is {1}", count, number);
                count++;
                sum = sum + number;
            }
            //calculate the average
            Double ave = sum / 20;
            
            Console.WriteLine();
            Console.WriteLine("The average is:" + ave);
            Console.WriteLine();

            foreach (int item in numbers)
            {
                //the diffrence between each number and the average, the command "math.abs(...) to show abslute numbers
                diff = ave - item;
                Console.WriteLine("the difference between the average and element {0} is {1:0.00}", num, Math.Abs(diff));
                num++;
            }
            
            Console.ReadKey();
        }
    }
}
