using System;

namespace Lesson02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Numbers average is {(num1 + num2 + num3) / 3}");
        }
    }
}
