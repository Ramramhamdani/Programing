using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1
{
   
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Console.Write("Enter a price: ");
            float input = float.Parse(Console.ReadLine());
            float VAT = VatCalculation(input);
            float Total = TotalPriceCal(input,VAT);
            Console.Write("price: {0:0.00}, VAT: {1:0.00}, total: {2:0.00}", input, VAT, Total);
            Console.ReadKey();
        }
        static float VatCalculation(float price)
        {
            float vat = (price * 21)/100;
            return vat;
            
        }
        static float TotalPriceCal(float price, float vat)
        {
            float total = price + vat;
            return total;
        }
    }
}
