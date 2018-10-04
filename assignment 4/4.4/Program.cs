using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int sum = 1;
            int count = 0;
            Console.Write(1);


            while (count<19)
            {

                //the 1st ans is 0+1 then the 1stnum becomes the second and the second becomes the ans "respectivly" 
                count++;
                
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                
                
                Console.Write(","+sum);
                
            }
            Console.ReadKey();
        }
    }
}
