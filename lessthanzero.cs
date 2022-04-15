using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {  // Is Number Less Than Zero  


            int num = 9;

            Console.WriteLine($"The number {num} is greater than zero {IsGreaterThanZero(num)}.");
        }

        static bool IsGreaterThanZero(int val)
        {
            return (val > 0);
        }
    }
}
