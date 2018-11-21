using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{

    class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }
        void start()
        {
            PrintMonth();
            //why PrintMonth(Month month); doesn't work?!
            string input = ReadMonth("Enter a month number: ").ToString();
            Console.ReadKey();
        }
        void PrintMonth(Month month)
        {
            Console.WriteLine(Month.January);
        }
        void PrintMonth()
        {
            int n = 1;
            for (Month month = Month.January; month <= Month.December; month++)
            {
                Console.WriteLine(n.ToString().PadLeft(2) + "." + month);
                n++;
            }
        }
        Month ReadMonth(string question)
        {
            Console.Write(question);
            string n = Console.ReadLine();
            Month mon = (Month)int.Parse(n);
            while (Enum.IsDefined(typeof(Month),mon)==false)
            {
                Console.WriteLine("{0} is not a valid value.", n);
                Console.Write(question);
                n = Console.ReadLine();
                mon = (Month)int.Parse(n);
            }
            Console.WriteLine(n + " => " + mon);
            return mon;

        }
       
    }
}
