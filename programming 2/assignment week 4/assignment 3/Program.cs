using System;
using System.IO;

namespace assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }
        void start()
        {
            Console.Write("Enter a word (to search): ");
            string word = Console.ReadLine();
            int count = SearchWordInFile("tweets-donaldtrump.txt", word);
            Console.WriteLine();
            Console.WriteLine("Number of lines containing the word: " + count);
            Console.ReadKey();
        }
        bool WordInLine(string line, string word)
        {
            line = line.ToLower();
            word = word.ToLower();
            if (line.Contains(word))
            {
                DisplayWordInLine(line, word);
                return true;
            }
            return false;
        }
        int SearchWordInFile(string filename, string word)
        {
            StreamReader reader = new StreamReader(filename);
            string line;
            int count = 0;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                if (WordInLine(line, word))
                {
                    count++;
                    //DisplayWordInLine(line, word);
                }
            }
            reader.Close();
            return count;
        }
        void DisplayWordInLine(string line, string word)
        {
            int start = line.IndexOf(word);
            int length = word.Length;
            if (line.Contains(word))
            {
                string found = line.Substring(line.IndexOf(word), word.Length);
            }
            //int chIndex;
            //foreach (char item in line)
            //{
            //    chIndex = line.IndexOf(item);
            //    //if (chIndex<start)
            //    //{
            //    //    Console.ResetColor();
            //    //}
            //    if (chIndex==start)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.Write(line.Substring(chIndex, length));
            //    }
            //    else
            //    {
            //        Console.ResetColor();
            //    }
            //    //else if (chIndex>(start+length))
            //    //{
            //    //    Console.ResetColor();
            //    //}
            //    Console.Write(item);
            //}

            for (int i = 0; i < line.Length; i++)
            {
                Console.ResetColor();
                if (i >= start && start + length > i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(line[i]);
            }

        }
    }
}
