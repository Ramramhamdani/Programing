using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight (kg): ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Enter lenght (cm): ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();
            Double square = (weight / (length * length)) * 10000;

            Console.WriteLine("bmi-value: {0:0.0}", square);

            switch (gender)
            {
                case "male":

                    Double a = square * 20;
                    Double b = square * 25;
                    Console.WriteLine("normal bmi-values(min...max): 20...25");
                    Console.WriteLine("healthy weight range: {0:0.0} .... {1:0.0}", a, b);
                    break;

                case "female":
                    Double FeRange = square * 19;
                    Double feEndRange = square * 24;
                    Console.WriteLine("normal bmi-values(min...max): 19...24");
                    Console.WriteLine("healthy weight range: {0:0.0} .... {1:0.0}", FeRange, feEndRange);
                    break;
            }
            Console.ReadKey();
        }
    }
}