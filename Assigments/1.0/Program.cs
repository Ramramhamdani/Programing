using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._0
{
    class Program
    {
        const double VAT = 0.21;
        static void Main(string[] args)
        {
            Console.Write("Enter price:");


            string input = Console.ReadLine();
            double price = double.Parse(input);
            // the price times the VAT 
            //the  answer divided by 100

            Double answer = price *VAT;
            Double FinlaAnswer = answer + price ;
            //to get 2 decimals use system.math.round(value,#)
            FinlaAnswer = System.Math.Round(FinlaAnswer,2); 
            


            //print the price, VAT and the final price

            Console.WriteLine("Price={0}, VAT={1}, Total={2}", price, answer, FinlaAnswer);

            Console.ReadKey();
            
        }
    }
}
