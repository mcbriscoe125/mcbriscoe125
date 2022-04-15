using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Calculate Profit Margin      

            double revenue = 5000.0;
            double cost = 3500.0;

            Console.WriteLine($"The profit margin of revenue {revenue} and cost {cost} is: {CalculateProfit(revenue, cost)} ");

            static double CalculateProfit(double num1, double num2)
            {
                return (num1 - num2) / num1;
            }
        }
    }
}