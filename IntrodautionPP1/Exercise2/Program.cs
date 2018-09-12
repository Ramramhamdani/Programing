using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);
           
       

            age = age + 1;
            int output = age;
            Console.WriteLine("Next year you will be{0} years old.",output);

            Console.ReadKey();
        }
    }
}
