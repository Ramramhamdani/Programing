using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name");
            
            String name;

            name = Console.ReadLine();

            Console.Write("Enter your age");

            string age = Console.ReadLine();
            

            Console.WriteLine("YOUR NAME IS {0}", name);
            Console.WriteLine("your age is {0}", age);

            Console.ReadKey();

        }
    }
}
