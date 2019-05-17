using System;

namespace Assignment_1
{
    class Programmer
    {
        public Specialty specialty;
        public string name;

        public Programmer(Specialty specialty, string name)
        {
            this.specialty = specialty;
            this.name = name;
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
