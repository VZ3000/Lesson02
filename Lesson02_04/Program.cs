using System;

namespace Lesson02_04
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

            DateTime courseStartDate = DateTime.Parse("2022-09-05");
            DateTime courseEndDate = DateTime.Parse("2023-03-01");
            var workDaysCount = ((courseEndDate - courseStartDate) / 7 * 4).Days;
            Console.WriteLine("Number of course days:" + workDaysCount);

        }
    }
}
