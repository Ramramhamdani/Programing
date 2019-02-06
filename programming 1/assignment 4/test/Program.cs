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
            Console.Write("Enter side:");
            int side = int.Parse(Console.ReadLine());
            for (int i = 1; i <= side; i++)
            {
                for (int x = 1; x <= side; x++)
                {
                    Console.Write("X");
                }
                Console.WriteLine("");

            }
            Console.ReadKey();

        }
    }
}
