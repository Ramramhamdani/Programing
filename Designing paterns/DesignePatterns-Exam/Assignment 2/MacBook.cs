using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class MacBook : Laptop
    {
        public MacBook(string SN):base(SN)
        {
            Processor = new IntelI5();
        }

    }
}
