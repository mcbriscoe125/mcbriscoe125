using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Is Number Odd

            int num = 8;

            bool isEven = IsNumOdd(num);

            bool IsNumOdd(int num1)
            {
                if (num1 % 2 != 0)
                {
                    Console.WriteLine($"The number {num1} is odd");
                    return true;
                }
                else
                {
                    Console.WriteLine($"The number {num1} is not odd");
                    return false;
                }
            }
        }
    }
}