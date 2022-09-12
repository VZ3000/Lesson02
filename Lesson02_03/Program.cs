using System;

namespace Lesson02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string schoolName;
            string className;
            int numberOfStudents;
            schoolName = "CodeAcademy";
            className = ".Net";
            numberOfStudents = 25;
            DateTime now = DateTime.Now;

            Console.WriteLine($"School name: {schoolName}, Class Name: {className}, Number of students: {numberOfStudents}, Current Date: {now}");

        }
    }
}
