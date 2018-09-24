using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter weight (kg): ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Enter lenght (cm): ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();
            Double square = length * length;
            Double one = square / 10000;
            Double BMI = weight / one;
            Console.WriteLine("bmi-value: {0:0.0}", BMI);

            switch (gender)
            {
                case "male":

                    Double a = one * 20;
                    Double b = one * 25;
                    Console.WriteLine("normal bmi-values(min...max): 20...25");
                    Console.WriteLine("healthy weight range: {0:0.0} .... {1:0.0}", a, b);
                    break;

                case "female":
                    Double FeRange = one * 19;
                    Double feEndRange = one * 24;
                    Console.WriteLine("normal bmi-values(min...max): 19...24");
                    Console.WriteLine("healthy weight range: {0:0.0} .... {1:0.0}", FeRange, feEndRange);
                    break;

            }
            
            Console.ReadKey();

           

        }
    }
}
