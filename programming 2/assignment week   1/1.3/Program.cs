using System;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.start();
        }
        void start()
        {
            person person = ReadPerson();
            PrintPerson(person);
            CelebrateBirthday(ref person);
            PrintPerson(person);
            person[] People = new person[3];
            for (int i = 0; i < People.Length; i++)
            {
                People[i] = ReadPerson();
            }
            for (int i = 0; i < People.Length; i++)
            {
                PrintPerson(People[i]);
            }

            Console.ReadKey();
        }
        person ReadPerson()
        {
            person person;
            person.FirstName = ReadString("Enter first name: ");
            person.LastName = ReadString("Enter last name: ");
            person.gender = ReadGender("Enter gender (m/f): ");
            person.Age = ReadInt("Enter your age: ");
            person.city = ReadString("Enter city: ");
            Console.WriteLine();
            return person;
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
        void PrintPerson(person p)
        {
            Console.Write(p.FirstName + " ");
            Console.Write(p.LastName);
            GenderType print = p.gender;//***********
            PrintGender(print);
            Console.Write(p.Age + " years old, ");
            Console.WriteLine(p.city);
            Console.WriteLine();
        }
        GenderType ReadGender(string question)
        {
            Console.Write(question);
            string input = (Console.ReadLine()).ToLower();
            GenderType gender = GenderType.male;
            if (input == "m")
            {
                gender = GenderType.male;
            }
            else if (input == "f")
            {
                gender = GenderType.female;
            }
            return gender;
        }
        void PrintGender(GenderType gender)
        {
            string output = "";
            if (gender == GenderType.male)
            {
                output = "m";
            }
            else if (gender == GenderType.female)
            {
                output = "f";
            }
            Console.WriteLine(" (" + output + ")");
        }
        void CelebrateBirthday(ref person person)
        {
            person.Age++;
           
        }
    }
}
