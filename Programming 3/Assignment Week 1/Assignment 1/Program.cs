using System;
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
            int nr = 0;
            while (nr!=4)
            {
                Programmer programmer = new Programmer();
                programmers.Add(programmer);
                nr++;
            }
            foreach (Programmer pro in programmers)
            {
                pro.Print();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
