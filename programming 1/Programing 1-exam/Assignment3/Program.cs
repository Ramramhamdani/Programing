using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0,100);
            }
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            foreach (int item in numbers)
            {
                //if the number in this range change the coulor
                if (item >= input - 10 && item <= input + 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(item + " ");
                }
                else if (item >= input - 20 && item <= input + 20)
                {
                    //if the number in this range change the coulor
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(item + " ");
                }
                else
                {
                    Console.ResetColor();
                    Console.Write(item + " ");
                }
                
            }
            Console.ReadKey();

        }
    }
}
