using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {  // Logical OR   


            int num1 = 0;
            int num2 = 1;

            Console.WriteLine($"The logical OR for {num1}  and {num2} is {GetLogicalOR(num1, num2)}.");
        }

        static bool GetLogicalOR(int val1, int val2)
        {
            bool boolOne = Convert.ToBoolean(val1);
            bool boolTwo = Convert.ToBoolean(val2);
            return (boolOne || boolTwo);
        }
    }
}