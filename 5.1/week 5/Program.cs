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
            Double sum = 0;
            Double dif = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rnd = new Random(); 
                numbers[i] = rnd.Next(0,200);
                for (int j = 0; j < numbers.Length; i++)
                {
                    int numbersNr = numbers[i];
                    Console.WriteLine("Element {0} is {1}", j, numbersNr);
                    sum = sum + numbersNr;
                   
                }
                double ave = sum / 20;
                Console.WriteLine("The average is: {0}", ave);
                foreach (int numberesNr in numbers)
                {
                    dif = ave - numberesNr;
                    Console.WriteLine("Difference between the average and the element {0} is {1}", j, dif);

                }

            }
           
           
                  
            
            Console.ReadKey();


            
        }
    }
}
