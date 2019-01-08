using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation
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
            Dictionary<string, string> words = new Dictionary<string, string>();
            words = ReadWords("dictionary.csv");
            TranslateWords(words);
        }
        Dictionary<string, string> ReadWords(string filename)
        {
            StreamReader stream = new StreamReader(filename);
            Dictionary<string, string> translater = new Dictionary<string, string>();
            string line = " ";
            while (!stream.EndOfStream)
            {
                line = line +stream.ReadLine()+";";
            }
            
            string[] words = line.Split(';');

            for (int i = 0; i < words.Length - 1; i++)
            {
                translater.Add(words[i], words[i + 1]);
            }
            return translater;
        }
        void TranslateWords(Dictionary<string, string> words)
        {
            string word = "";
            while (word != "stop")
            {
                Console.Write("Enter a word: ");
                word = Console.ReadLine().ToLower();
                if (words.ContainsKey(word))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{word}=>{words[word]}");
                }
                else if (word == "listall")
                {
                    ListAllWords(words);
                }
                else if (!words.ContainsKey(word))
                {
                    Console.WriteLine("The word cannot be found.");
                }
                
                Console.ResetColor();
            }
        }
        void ListAllWords(Dictionary<string,string> words)
        {
            foreach (KeyValuePair<string,string> item in words)
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
            }
            Console.ReadKey();
        }
    }
}
