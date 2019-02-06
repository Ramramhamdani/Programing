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
            int input = 1;
            int[] numbers = new int[20];
            int count = 0;
            while(input!=0&&count<20)
            {
                // fill the array with number from the user
                Console.Write("Enter a number (0=stop): ");
                input = int.Parse(Console.ReadLine());
                count++;
            }
            Console.Write("Enter a search value: ");
            int Search = int.Parse(Console.ReadLine());
            int occurence = 0;
            //search the number
            for(int i=0;i<numbers.Length;i++)
            {
                if (i == Search)
                {
                    occurence++;
                }
            }
            Console.WriteLine("number of search value {0} is: {1}", Search, occurence);
            Console.ReadKey();
        }
    }
}
