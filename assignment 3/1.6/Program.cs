using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());
            //for empty space write empty quotes
            Console.Write(" ");
            if (score <= 100 && score >= 90)
            {
                Console.WriteLine("Grade: A");
                Console.WriteLine("course passed");
            }
            else if (score <= 89 && score >= 80)
            {
                Console.WriteLine("Grade: B");
                Console.WriteLine("course passed");

            }
            else if (score <= 79 && score >= 70)
            {
                Console.WriteLine("Grade: C");
                Console.WriteLine("course passed");
            }
            else if (score <= 69 && score >= 60)
            {
                Console.WriteLine("Grade: D");
                Console.WriteLine("course not passed");
            }
            else if (score<60)
            {
                Console.WriteLine("Grade: F");
                Console.WriteLine("course not passed");
            }
            Console.ReadKey();
        }
    }
}
