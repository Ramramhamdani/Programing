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
            int input=1;
            int[] numbers = new int[20];
            for (int i = 1; i < numbers.Length; i++)
            {

               
                if (input != 0)
                {
                    Console.Write("Enter a number (0=stop): ");
                    input = int.Parse(Console.ReadLine());
                }
                numbers[i] = input;
            }
        
            Console.Write("Enter a search value: ");
            int Search = int.Parse(Console.ReadLine());
            int occurence = 0;
            foreach (int item in numbers)
            {
                if (item == Search)
                {
                    occurence++;
                }
            }
            Console.WriteLine("number of search value {0} is: {1}", Search, occurence);
            Console.ReadKey();
        }
    }
}
