using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year (0 is stop value): ");
            int year = int.Parse(Console.ReadLine());
            bool LeapYear = true;

            while (year != 0)
            {
                LeapYear = IsLeapYear(year);
                //if the year is dividable by 400 or 4 but not by 100 it's leap
                if (LeapYear)
                {
                    Console.WriteLine("{0} is a leap year.", year);
                }
                // if the year is no divividable by 400 or 4 but dividable by 100 it's not leap 
                else // if (LeapYear==false)
                {
                    Console.WriteLine("{0} is not a leap year.", year);
                }
                
                Console.Write("Enter a year (0 is stop value): ");
                year = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("End of program");
            Console.ReadKey();
        }

        static bool IsLeapYear(int year)
        {
            bool LeapYear = true;
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                LeapYear = true;
            }
            // if the year is no divividable by 400 or 4 but dividable by 100 it's not leap 
            else // if (year % 400 != 0 || year % 4 != 0 && year % 100 == 0)
            {
                LeapYear = false;
            }
            return LeapYear;

        }
    }
}
