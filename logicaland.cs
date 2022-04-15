using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Logical AND      

            int value1 = 0;
            int value2 = 1;

            Console.WriteLine($"The logical AND of {value1} and {value2} is: {IsAnd(value1, value2)} ");

            static bool IsAnd(int num1, int num2)
            {
                bool boolOne = Convert.ToBoolean(num1);
                bool boolTwo = Convert.ToBoolean(num2);
                return boolOne && boolTwo;
            }
        }
    }
}
