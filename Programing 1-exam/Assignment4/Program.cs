using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int count = 0;
            while (number < 100)
            {
                count = CountDividers(number);
                //if the number has two dividres print it with the value of count
                if (count == 2)
                {
                    Console.WriteLine(number + ":" + count);
                }
                number++;

            }
            Console.WriteLine("End of program");

            Console.ReadKey();
        }
        static int CountDividers(int number)
        {

            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    //if the number is dividable by i add 1 to "count"
                    count++;
                }
            }



            return count;
        }
    }
}
