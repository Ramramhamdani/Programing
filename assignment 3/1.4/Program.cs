using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int third = int.Parse(Console.ReadLine());
            int sum = first + second + third;
            Double ave = sum / 3;
            int product = first * second * third;
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("Average ={0:0.00} ", ave);
            Console.WriteLine("Product = " + product);
            int biggest;
            int smallest;
            //the biggest number
            if (first>second && first>third )
            {
                biggest = first;
                Console.WriteLine("Highest = " + biggest);
            }
            else if (second>first && second>third)
            {
                biggest = second;
                Console.WriteLine("Highest = " + biggest);
            }
            else if (third>first && third>second)
            {
                biggest = third;
                Console.WriteLine("Highest = " + biggest);
            }
            // the smallest number
            if (first<second && first<third)
            {
                smallest = first;
                Console.WriteLine("Lowest = " + smallest);

            }
            else if (second<first && second<third)
            {
                smallest = second;
                Console.WriteLine("Lowest = " + smallest);

            }
            else if (third<first && third<second)
            {
                smallest = third;
                Console.WriteLine("Lowest = " + smallest);

            }
            Console.ReadKey();




        }   
    }
}
