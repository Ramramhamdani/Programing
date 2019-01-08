using System;
using System.Collections.Generic;
using System.IO;

namespace lingo
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
            List<string> words = new List<string>();
            words = ReadWords("words.txt");
            string lingoWord = ChooseWord(words);
            PlayLingo(lingoWord);
        }
        List<string> ReadWords(string filename)
        {
            StreamReader stream = new StreamReader(filename);
            List<string> words = new List<string>();
            while (!stream.EndOfStream)
            {
                words.Add(stream.ReadLine());
            }
            stream.Close();
            return words;
        }
        string ChooseWord(List<string> words)
        {
            Random random = new Random();
            int i=0;
            string word = "";
            while (word.Length!=5)
            {
                i = random.Next(0, words.Count);
                word = words[i];
            }
            
            return word;
        }
        void PlayLingo(string lingoWord)
        {
            int count = 1;
            int attemptsLeft = 5;
            bool guessed = false;
            string playerWord = "";
            int[] results = new int[5];
            while (!guessed && attemptsLeft > 0)
            {
                Console.Write($"Enter a (5-letter) word, attempt {count}: ");
                count++;
                playerWord = ReadPlayerWord(lingoWord.Length);
                results = EvaluatedWord(playerWord, lingoWord);
                DisplayResults(playerWord.ToUpper(), results);
                guessed = IsGuessed(lingoWord, playerWord);
                attemptsLeft = attemptsLeft - 1;
            }
        }
        string ReadPlayerWord(int length)
        {

            string word = "";
            do
            {
                word = Console.ReadLine();
            } while (word.Length != length);
            return word;
        }
        int[] EvaluatedWord(string playerWord, string lingoWord)
        {
            int[] results = new int[5];
            int pos = 0;
            string refLetters = "";
            //List<char> refLetters = new List<char>();
            for (int i = 0; i <= lingoWord.Length-1; i++)
            {
                if (playerWord[i] != lingoWord[i])
                {
                    refLetters = refLetters + lingoWord[i];
                    //refLetters.Add(lingoWord[i]);
                }
            } 
            for (int i = 0; i <= playerWord.Length - 1; i++)
            {
                if (playerWord[i] == lingoWord[i])
                {
                    results[i] = 1;         //1= right
                }
                else
                {
                    //if (refLetters.Contains(playerWord[i]))
                    //{
                    //    results[i] = 0;     // 0= wrong pos
                    //    refLetters.Remove(playerWord[i]);
                    //}
                    pos = refLetters.IndexOf(playerWord[i]);
                    if (pos >= 0)
                    {
                        results[i] = 0;
                        refLetters = refLetters.Remove(pos, 1);
                    }
                    else
                    {
                        results[i] = 2;         //2= incorrect
                    }
                }
            }
            return results;
        }
        void DisplayResults(string playerWord, int[] results)
        {
            for (int i = 0; i < playerWord.Length; i++)
            {
                if (results[i] == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else if (results[i] == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                Console.Write(playerWord[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        bool IsGuessed(string lingoWord, string playerWord)
        {
            return lingoWord == playerWord;
        }
    }
}
