using System;
using System.IO;
using System.Collections.Generic;

namespace Assignment_2
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
            HangmanGame hangman = new HangmanGame();
            List<string> ListOfWords = new List<string>();
            ListOfWords = ListOfWords1();
            string word = SelectWord(ListOfWords);
            hangman.Init(word);
            PlayHangman(hangman);

            Console.ReadKey();
        }
        List<string> ListOfWords1()
        {
            List<string> ListOfWords = new List<string>();
            StreamReader reader = new StreamReader("words.txt");
            while (!reader.EndOfStream)
            {
                ListOfWords.Add(reader.ReadLine());
            }
            return ListOfWords;
        }
        string SelectWord(List<string> Words)
        {
            Random random = new Random();
            int num = 0;
            string word = "";
            while (word.Length<3)
            {
                num= num = random.Next(0, Words.Count);
                word = Words[num];
            }
            return word;
        }
        bool PlayHangman(HangmanGame hangman)
        {
            List<char> enteredLetters = new List<char>();
            Console.Write("The guesed word is: ");
            DisplayWord(hangman.guessedWord);
            if (hangman.secretWord == hangman.guessedWord)
            {
                return true;
            }
            int count = 8;
            bool isThere;
            while ((hangman.guessedWord != hangman.secretWord)&&(count!=0))
            {
                isThere = false;
                ReadLetter(enteredLetters);
                /*Console.Write("Enter a letter: ");
                string letter = Console.ReadLine().ToString();
                foreach (char item in letter)
                {
                    enteredLetters.Add(item);
                }
                Console.Write("Entered letters: ");
                DisplayLetters(enteredLetters);*/
                string word = "";
                foreach (char hrf in hangman.secretWord)
                {
                    if (enteredLetters.Contains(hrf))
                    {
                        word = word + hrf;
                    }
                    else
                    {
                        word = word + ".";
                    }
                }
                foreach (char item in hangman.secretWord)
                {
                    if (item==enteredLetters[enteredLetters.Count-1])
                    {
                        isThere = true;
                        break;
                    }
                }
                if (!isThere)
                {
                    count--;
                }
                Console.WriteLine("Attempts left: {0}", count);
                hangman.guessedWord = word;
                DisplayWord(hangman.guessedWord);
            }
            return false;
        }
        void DisplayWord(string word)
        {
            foreach (char letter in word)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();
        }
        void DisplayLetters(List<char> letters)
        {
            foreach (char ch in letters)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
        }
        char ReadLetter(List<char> blacklistLetters)
        {
            Console.Write("Enter a letter: ");
            string letter = Console.ReadLine().ToString();
            foreach (char item in letter)
            {
                if (blacklistLetters.Contains(item))
                {
                    break;
                }
                else
                {
                    blacklistLetters.Add(item);
                    Console.Write("Entered letters: ");
                    DisplayLetters(blacklistLetters);
                    return item;
                }

            }
            char ch = char.Parse(letter);
            return ch;
        }

    }
}
