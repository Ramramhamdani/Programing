using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter course name: ");
            string course = Console.ReadLine();
            Console.Write("Enter number of students: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int count = 1;
            Double sum = 0;
            string maxGrade = "";
            string[] students = new string[number];
            Double[] grades = new Double[number];
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Enter name of student {0}: ", count);
                students[i] = Console.ReadLine();
                count++;

            }
            Console.WriteLine();
            
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Enter grade of {0}: ", students[i]);
                grades[i] = Double.Parse(Console.ReadLine());
                sum = sum + grades[i];
            }
            double max = grades.Max();
            Console.WriteLine();
            Double ave = sum / number;
            Console.WriteLine("Average grade: {0:0.00}", ave);
            for (int i = 0; i < grades.Length; i++)
            {
                if (max==grades[i])
                { 
                    maxGrade = students[i];
                }
            }


            Console.WriteLine("student {0} has maximum grade {1}",maxGrade, max);
            Console.WriteLine();

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Grade for student {0} ({1}) is: {2}", students[i], course, grades[i]);
            }
            Console.ReadKey();
        }
    }
}
