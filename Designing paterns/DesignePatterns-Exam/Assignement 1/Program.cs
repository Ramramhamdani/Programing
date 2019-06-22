using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
            Console.ReadKey();
        }
        void Start()
        {
            PrintHeader("[wooden house]");
            BaseHouse house1 = new WoodenHouse();
            house1.BuildHouse();

            Console.WriteLine();

            PrintHeader("[glass house]");
            BaseHouse house2 = new GlassHouse();
            house2.BuildHouse();

            Console.WriteLine();

            PrintHeader("[concrete house]");
            BaseHouse house3 = new ConcreteHouse();
            house3.BuildHouse();
        }
        private void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ResetColor();
        }
    }
}
