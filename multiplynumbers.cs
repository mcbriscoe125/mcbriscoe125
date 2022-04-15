using System;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        { //  Multiply numbers
            double num1 = 10.5;
            double num2 = 7.3;
            double value = System.Math.Round(MultiplyNum(num1, num2), 2);

            Console.WriteLine($"The product of {num1} and {num2} is: {value} ");

        }

        private static double MultiplyNum(double a, double b)
        {
            double value = a * b;

            return value;
        }
    }
}