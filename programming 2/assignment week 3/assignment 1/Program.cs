using System;
using System.Collections.Generic;

namespace assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.start();
        }
        void start()
        {
            course course = new course();
            PracticalGrade practical = new PracticalGrade();
            course = ReadCourse("Enter a course");
            DisplayCourse(course);
            List<course> report = new List<course>();
            report = ReadReport(report);
            DisplayReport(report);
            Console.ReadKey();
        }
        PracticalGrade ReadPracticalGrade(string question)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            PracticalGrade practical = (PracticalGrade)int.Parse(Console.ReadLine());
            Console.ResetColor();
            return practical;
        }
        void DisplayPracticalGrade(PracticalGrade practical)
        {
            Console.WriteLine(practical);
        }
        course ReadCourse(string question)
        {
            course course = new course();
            Console.WriteLine("Enter a course");
            Console.Write("Name of the course: ");
            Console.ForegroundColor = ConsoleColor.Green;
            course.name = Console.ReadLine();
            Console.ResetColor();
            Console.Write("Grade for {0}: ", course.name);
            Console.ForegroundColor = ConsoleColor.Green;
            course.grade = int.Parse(Console.ReadLine());
            int n = 0;
            Console.ResetColor();
            for (PracticalGrade grade = PracticalGrade.None; grade <= PracticalGrade.good; grade++)
            {
                Console.Write(n + ". " + grade + " ");
                n++;
            }
            Console.WriteLine();
            Console.Write("Practical grade for {0}: ", course.name);
            course.practical = ReadPracticalGrade(question);
            return course;
        }
        void DisplayCourse(course course)
        {
            Console.WriteLine(course.name + " : " + course.grade + " " + course.practical);
            if (!course.Passed())
            {
                Console.WriteLine("Too bad, you did not graguated, you've got 2 retakes.");
            }
            else if (course.CumLaude())
            {
                Console.WriteLine("congratulations!, you passed Cum Laude.");
            }
            Console.WriteLine();
        }
        List<course> ReadReport(List<course> courses)
        {
            course course = new course();
            for (int i = 0; i < 3; i++)
            {
                course = ReadCourse("Enter a course.");
                courses.Add(course);
                Console.WriteLine();
            }
            return courses;
        }
        void DisplayReport(List<course> courses)
        {
            foreach (course course in courses)
            {
                DisplayCourse(course);
            }
        }
    }
}
