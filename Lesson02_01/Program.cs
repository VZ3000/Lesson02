using System;

namespace Lesson02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Numbers sum is {num1 + num2}");
            Console.WriteLine($"Numbers subtracion is {num1 - num2}");
            Console.WriteLine($"Numbers multiplication is {num1 * num2}");
            Console.WriteLine($"Numbers division is {num1 / num2}");

        }
    }
}
