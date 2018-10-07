using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            int[] numbers = new int[20];
            Random rnd = new Random();
            int count = 0;
           //fill the array random numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 150);
                Console.WriteLine("Element {0} is {1}", count, numbers[i]);
                count++;
            }
            //find the smallest number
            int min = numbers.Min();
            int occurence = 0;
            //find howmany times the minimum is repeated
            foreach (int item in numbers)
            {
                if (item==min)
                {
                    occurence++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Smallest number = {0}", min);
            Console.WriteLine("number of occurance = {0}", occurence);
            Console.WriteLine("Try again! [Y/N]");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                goto start;
            }
            else
            {
               
            }
        }
    }
}
