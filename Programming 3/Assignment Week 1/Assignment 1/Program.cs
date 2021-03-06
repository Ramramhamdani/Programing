﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
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
            List<Programmer> programmers = new List<Programmer>();
            Team team = new Team();
            int nr = 0;
            while (nr!=4)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter specialty: ");
                Specialty specialty = (Specialty)Enum.Parse(typeof(Specialty), Console.ReadLine().ToLower());
                Programmer programmer = new Programmer(specialty, name);
                //programmers.Add(programmer);
                team.AddProgrammer(programmer);
                nr++;
            }
            team.PrintAllTeam();
            Programmer programmer1 = new Programmer("Peter");
            team.AddProgrammer(programmer1);
            team.PrintAllTeam();
            //foreach (Programmer pro in programmers)
            //{
            //    pro.Print();
            //    Console.WriteLine();
            //}
            Console.ReadKey();
        }
    }
}
