using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            int value = ReadTools.ReadInt("Enter a value: ");
            Console.WriteLine("You enterd {0}", value);

            int age = ReadTools.ReadInt("Enter your age: ");
            Console.WriteLine("You are {0} years old.", value);

            string name = ReadTools.ReadString("What is your name? ");
            Console.WriteLine("Nice meeting you {0}", name);

            Console.ReadKey();
        }
    }
}
