using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            int starNr = 0;
            int excleNr = 0;

            while (input > 0)
            {
                // string inside the loop to be empty every time

                string exc = "";
                string stars = "";
                string output = "";
                starNr = input / 2;
                excleNr = input - starNr;
                for (int i = 0; i < starNr; i++)
                {
                    stars = stars + "*";
                }
                for (int i = 0; i < excleNr; i++)
                {
                    exc = exc + "!";
                }
                output = stars + exc;
                Console.WriteLine(output);
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());

            }
            Console.ReadKey();
        }
    }
}
