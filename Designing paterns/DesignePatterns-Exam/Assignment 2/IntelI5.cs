using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class IntelI5 : IProcessor
    {
        
        public string Execute()
        {
            string msg = "with Processor intel i5";
            return msg;
        }
    }
}
