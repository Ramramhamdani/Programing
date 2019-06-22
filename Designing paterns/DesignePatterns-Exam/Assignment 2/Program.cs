using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
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
            PrintHeader("MacBook");
            Laptop macBook = new MacBook("A1278");
            macBook.Execute("virusscanner.exe");

            PrintHeader("HP");
            Laptop hp = new HPLaptop("S/N 893491");
            hp.Execute("virusscanner.exe");

            PrintHeader("changed MacBook");
            macBook.Processor = new Inteli7();
            macBook.Execute("virusscanner.exe");
            
        }
        void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ResetColor();
        }
    }
}
