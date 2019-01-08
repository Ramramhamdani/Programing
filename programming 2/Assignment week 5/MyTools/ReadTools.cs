using System;

namespace MyTools
{
    public class ReadTools
    {
        public static int ReadInt(string question)
        {
            int max = 0;
            int min = 0;
            Console.Write(question);
            int input = ReadInt(question, max, min);
            return input;
        }
        private static int ReadInt(string question, int max, int min)
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
        public static string ReadString(string question)
        {
            Console.Write(question);
            string input = Console.ReadLine();
            return input;
        }
    }
}
