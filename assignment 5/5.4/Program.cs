using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int[] numbers = new int[20];
            for (int i = 1; i < numbers.Length; i++)
            {
               
                Console.Write("Enter a number (0=stop): ");
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] == 0)
                {
                    goto start;
                }
            }
            start:
            Console.Write("Enter a search value: ");
            int Search = int.Parse(Console.ReadLine());
            int occurence = 0;
            foreach (int item in numbers)
            {
                if (item==Search)
                {
                    occurence++;
                }
            }
            Console.WriteLine("number of search value {0} is: {1}", Search, occurence);
            Console.ReadKey();
        }
    }
}
