using System;
using System.Collections.Generic;

namespace Assignment_3
{
    class RegistrationSystem
    {
        private static RegistrationSystem system;
        Dictionary<int, Employee> employees;

        public int NrOfClockedInEmployees { get; set; }

        private RegistrationSystem()
        {
            employees = new Dictionary<int, Employee>();
        }

        public static RegistrationSystem GetInstance()
        {
            if (system == null)
            {
                system = new RegistrationSystem();
            }
            return system;
        }
        public void ClockIn(Employee employee)
        {
            if (employees.ContainsKey(employee.number))
            {
                Console.WriteLine($"Employee {employee.name} already clocked in!");
            }
            else
            {
                employees.Add(employee.number, employee);
                Console.WriteLine($"Employee {employee.name} clocked in. ");
            }

        }
        public void ClockOut(Employee employee)
        {
            if (!employees.ContainsKey(employee.number))
            {
                Console.WriteLine($"Employee {employee.name} already clocked out!");
            }
            else
            {
                employees.Remove(employee.number, employee);
                Console.WriteLine($"Employee {employee.name} clocked in. ");
            }
        }
    }
}
