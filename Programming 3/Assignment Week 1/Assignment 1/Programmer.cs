using System;

namespace Assignment_1
{
    class Programmer
    {
        public Specialty specialty;
        public string name;

        public Programmer()
        {
            // there should be parameters passed no reading in the constructor
            // parameters name, especialty
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter specialty: ");
            specialty = (Specialty)Enum.Parse(typeof(Specialty), Console.ReadLine().ToLower());
            // Is this the right way to convert string to Enum??
        }
        public Programmer(Specialty specialty)
        {

        }
        public void Print()
        {
            Console.Write($"Name: {name}, Specialty: {specialty}");
        }
        public Programmer(string name)
        {
            this.name = name;
            specialty = Specialty.unknown;
        }
        
    }
}
