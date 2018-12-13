using System;
using System.IO;

namespace assignment_1
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
            person person = new person();
            person = ReadPerson();
            if (File.Exists(person.name))
            {
                person = ReadPerson(person.name);
                DisplayPerson(person);
            }
            else
            {
                WritePerson(person, person.name);
            }
            
            
            Console.ReadKey();
        }
        person ReadPerson()
        {
            person person = new person();
            Console.Write("Enter your name: ");
            person.name = Console.ReadLine();
            if (File.Exists(person.name))
            {
                person = ReadPerson(person.name);
                Console.WriteLine("Nice to see you again, {0}!", person.name);
                Console.WriteLine("We have the following information about you.");

            }
            else
            {
                Console.Write("Enter your age: ");
                person.age = int.Parse(Console.ReadLine());
                Console.Write("Enter your city: ");
                person.city = Console.ReadLine();
                WritePerson(person, person.name);
            }
            
            return person;
        }
        void DisplayPerson(person p)
        {
            
            Console.WriteLine("Hello {0}", p.name);
            Console.WriteLine("age: "+p.age);
            Console.WriteLine("city: "+ p.city);
            
        }
        void WritePerson(person p, string data)
        {
            Console.WriteLine("writing file...");
            StreamWriter writer = new StreamWriter(data);
            writer.WriteLine(p.name);
            writer.WriteLine(p.age);
            writer.WriteLine(p.city);
            writer.Close();
        }
        person ReadPerson(string filename)
        {
            person person = new person();
            string read;
            
            StreamReader reader = new StreamReader(filename);
            read = reader.ReadLine();
            person.name = read;
            person.age = int.Parse(reader.ReadLine());
            read = reader.ReadLine();
            person.city = read;
            reader.Close();
            return person;
        }
    }
}
