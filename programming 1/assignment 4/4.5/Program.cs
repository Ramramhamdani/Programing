using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
           
            
                while (year!=0)
                {
                //if the year is dividable by 400 or 4 but not by 100 it's leap
                    if ((year%400==0 || year%4==0&&year%100!=0)&&year>0 )
                    {
                        Console.WriteLine("{0} is a leap year.", year);
                    }
                    // if the year is no divividable by 400 or 4 but dividable by 100 it's not leap 
                    else if ((year%400!=0 || year%4!=0)&& year > 0 && year%100 == 0)
                    {
                        Console.WriteLine("{0} is not a leap year.",year);
                    }
                    //if year is nigative number show it must be positive
                    else if (year < 0)
                    {
                        Console.WriteLine("year must be positive.");
                    }
                    Console.Write("Enter a year: ");
                    year = int.Parse(Console.ReadLine());
                }
            
           
            
        }
    }
}
