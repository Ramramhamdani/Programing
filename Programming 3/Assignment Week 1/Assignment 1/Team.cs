using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Team
    {
        public Programmer programmer1;
        public Programmer programmer2;
        public Programmer programmer3;
        public Programmer programmer4;
        List<Programmer> programmers = new List<Programmer>();

        public Team()
        {
            //programmer1.name = "Ram";
            //programmer1.specialty = Specialty.csharp;
            //programmer1.name = "Rash";
            //programmer1.specialty = Specialty.html;
            //programmer1.name = "Zak";
            //programmer1.specialty = Specialty.java;
            //programmer1.name = "Pam";
            //programmer1.specialty = Specialty.php;
            AddProgrammer(programmer1);
            AddProgrammer(programmer2);
            AddProgrammer(programmer3);
            AddProgrammer(programmer4);
        }
        public void PrintAllTeam()
        {
            Console.Write($"Name: {programmer1.name}, Specialty: {programmer1.specialty}" + "\n" + $"Name: {programmer2.name}, Specialty: {programmer2.specialty}" + "\n"+
                $"Name: {programmer3.name}, Specialty: {programmer3.specialty}" + "\n"+$"Name: {programmer4.name}, Specialty: {programmer4.specialty}");
        }
        public void AddProgrammer(Programmer p)
        {
            programmers.Add(p);
        }
    }
}
