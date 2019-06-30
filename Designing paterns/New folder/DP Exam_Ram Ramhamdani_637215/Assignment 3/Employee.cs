using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Employee
    {
        public string name;
        public int number;

        public Employee( string name, int num)
        {
            this.name = name;
            this.number = num;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
