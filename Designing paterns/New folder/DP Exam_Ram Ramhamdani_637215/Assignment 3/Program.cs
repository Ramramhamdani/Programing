using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationSystem registrationSystem = RegistrationSystem.GetInstance();

            Console.ForegroundColor = ConsoleColor.Green;
            Employee employee = new Employee("Ronald",11290);
            Employee employee2 = new Employee("Kevin", 10671);
            registrationSystem.ClockIn(employee);
            registrationSystem.ClockIn(employee2);
            registrationSystem.ClockIn(employee);

            RegistrationSystem registrationSystem2 = RegistrationSystem.GetInstance();
            registrationSystem2.ClockOut(employee);
            registrationSystem2.ClockOut(employee);
            registrationSystem2.ClockOut(employee2);

        }
    }
}
