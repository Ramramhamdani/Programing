using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[20];

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write("Enter a word: ");
                words[i] = Console.ReadLine();

                if (words[i]=="")
                {
                    break;
                }
                
            }
            foreach (string item in words)
            {
                if (item != null)
                {
                    if (item.Length % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(item);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(item);
                    }
                }

            }
            Console.ResetColor();
            Console.WriteLine("End of progrm");




            Console.ReadKey();
        }
    }
}
