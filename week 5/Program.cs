using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int[] asnwers = new int[20];
            Double sum = 0;
            Double dif = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rnd = new Random(); 
                numbers[i] = rnd.Next(0,200);
                for (int i = 0; i < numbers.Length; i++)
                {
                    int numberTax = Math.Abs(numbers[i]);
                    Console.WriteLine("Element {0} is {1}", i, numberTax);
                    
                }
                sum = sum + numberTax;
            }
            
            Double ave = sum / 20;
            Console.WriteLine("The average is: ", ave);
            foreach (int num in numbers)
            {
                Double Diff = ave - num;
                Console.WriteLine("The differencce between the average and the element{0} is ", num);
            }

            Console.ReadKey();
            
        }
    }
}
