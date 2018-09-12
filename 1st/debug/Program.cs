using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your age:");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            age = age + 1;
            string output = age.ToString();
            Console.WriteLine("next year you will be {0} years old",output);
            Console.ReadKey();


            


                 

        }
    }
}
