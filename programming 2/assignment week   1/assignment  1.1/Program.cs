using System;

namespace assignment__1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.Start();
        }
        void Start()
        {
            int value = ReadInt("Enter a value: ");
            Console.WriteLine("You enterd {0}", value);

            int age = ReadInt("Enter your age: ");
            Console.WriteLine("You are {0} years old.", value);

            string name = ReadString("What is your name? ");
            Console.WriteLine("Nice meeting you {0}", name);

            Console.ReadKey();
        }
        int ReadInt(string question)
        {
            int max = 0;
            int min = 0;
            Console.Write(question);
            int input = ReadInt(question, max, min);
            return input;
        }
        int ReadInt(string question, int max, int min)
        {
            int input = int.Parse(Console.ReadLine());
            min = 0;
            max = 120;
            while (input <= min || input >= max)
            {
                Console.Write(question);
                input = int.Parse(Console.ReadLine());
            }
            return input;
        }
        string ReadString(string question)
        {
            Console.Write(question);
            string input = Console.ReadLine();
            return input;
        }
    }
}
