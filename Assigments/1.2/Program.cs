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
            Console.Write("Enter 1st number:");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number:");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter 3rd number:");
            int third = int.Parse(Console.ReadLine());

            float answer = first + second + third;
            float FinalAnswer = answer / 3;

            Console.WriteLine("the average is:{0}", FinalAnswer);
            Console.ReadKey(); 
            


        }
    }
}
