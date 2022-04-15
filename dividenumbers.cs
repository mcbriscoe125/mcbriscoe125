using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Divide Numbers  

            double value1 = 8.6;
            double value2 = 4.2;

            Console.WriteLine($"The quotient of {value1} and {value2} is: {DivideNums(value1, value2)} ");

            double DivideNums(double num1, double num2)
            {
                double answer = (num1 / num2);
                double roundedValue = System.Math.Round(answer, 2);
                return roundedValue;
            }
        }
    }
}