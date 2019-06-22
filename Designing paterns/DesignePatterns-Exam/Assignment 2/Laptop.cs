using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    abstract class Laptop
    {
        string serialNumber;
        public IProcessor Processor;
        string scanner;

        public Laptop(string SN)
        {
            serialNumber = SN;
        }
        public void Execute(string scanner)
        {
            string processor = Processor.Execute();
            this.scanner = scanner;
            Console.WriteLine($"executing program '{scanner}' {processor}");
        }
    }
}
