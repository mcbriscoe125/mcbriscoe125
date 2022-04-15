using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Is Number Even  

            int num = 7;

            bool isEven = IsNumEven(num);

            bool IsNumEven(int num1)
            {
                if (num1 % 2 == 0)
                {
                    Console.WriteLine($"The number {num1} is even");
                    return true;
                }
                else
                {
                    Console.WriteLine($"The number {num1} is not even");
                    return false;
                }
            }
        }
    }
}
