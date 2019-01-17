using System;
using System.Linq;

namespace Assignment_1
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
            Console.Write("Enter a message: ");
            string massage = Console.ReadLine();
            Console.Write("Enter a secret key: ");
            string key = Console.ReadLine().ToLower();
            string substitutionAlphabet = CreatesubstitutionAlphabet(key, "abcdefghijklmnopqrstuivwxyz");
            string output = ReplaceText(massage, "abcdefghijklmnopqrstuivwxyz", substitutionAlphabet);
            Console.Write($"Encrypted message: {output}");
            Console.ReadKey();
        }
        string CreatesubstitutionAlphabet(string key, string standardAlphabet)
        {
            string alphabetTemp = key + "abcdefghijklmnopqrstuivwxyz";
            string substitutionAlphabet = "";
            for (int i = 0; i < alphabetTemp.Length; i++)
            {
                if (!substitutionAlphabet.Contains(alphabetTemp[i]))
                {
                    substitutionAlphabet = substitutionAlphabet + alphabetTemp[i];
                }
            }
            return substitutionAlphabet;
        }
        string ReplaceText(string input, string standardAlphabet, string substitutionAlphabet)
        {
            int pos = 0;
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                pos = standardAlphabet.IndexOf(input[i]);
                if (pos < 0)
                {
                    output = output + input[i];
                }
                else
                {
                    output = output + substitutionAlphabet[pos];
                }
            }
            return output;
        }
    }
}
