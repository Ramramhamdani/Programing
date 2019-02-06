using System;

namespace Assignment_1
{
    class Programmer
    {
        public Specialty specialty;
        public string name;

        public Programmer()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter specialty: ");
            specialty = (Specialty)Enum.Parse(typeof(Specialty), Console.ReadLine().ToLower());
            // Is this the right way to convert string to Enum??
        }

        public void Print()
        {
            Console.Write($"Name: {name}, Specialty: {specialty}");
        }
    }
}
