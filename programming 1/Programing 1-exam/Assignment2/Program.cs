using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            while (word!="stop")
            {
                
                foreach (char item in word)
                {
                    //calculate the value for each char and show it
                    int ascii = (int)item;
                    Console.Write(item + "=" + ascii+"     ");
                }
                Console.Write("\n"+"Enter a word: ");
                word = Console.ReadLine();

            }
            Console.WriteLine("End of program");
            Console.ReadKey();
        }
    }
}
