using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();
            string word = "";
            int letters = input.Length;
            while (letters!=0)
            {
                char letter = input[letters-1];
                word = word + letter;
                letters--;
            }
            
            if (word==input)
            {
                Console.WriteLine("{0} is a palindrome", input);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome", input);
            }
            Console.ReadKey();
            
            

        }
    }
}
