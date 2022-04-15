using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Subtract Numbers    

            int value1 = 8234;
            int value2 = 46346;

            Console.WriteLine($"The difference of {value1} and {value2} is: {SubNums(value1, value2)} ");

            decimal SubNums(int num1, int num2)
            {
                return (num1 - num2);
            }
        }
    }
}