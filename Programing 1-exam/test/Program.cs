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
            int count = 0;
            int number = 0;
            bool twoDiv = true;
            while (number<100)
            {
                number++;
                
                 count = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }




                Console.WriteLine(number+":"+count);
            }
            Console.ReadKey();
        }
    }
}
