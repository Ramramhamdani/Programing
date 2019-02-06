using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.Write("Enter numbre of seconds:");
            int input = int.Parse(Console.ReadLine());
            // variable hours is the the num to print in hr
            int hours = input / 3600;
            int RemainderMinInSec = hours * 3600;
            int remainderTotalSec = input - RemainderMinInSec;
            // variable min is the num to print in min
            int min = remainderTotalSec / 60;
            int totsec = min * 60;
            // variable sec is the num to print in sec
            int sec = remainderTotalSec - totsec;

            Console.WriteLine("{0}:{1}:{2}", hours, min, sec);
            Console.ReadKey();
            goto start;


            






        }
    }
}
