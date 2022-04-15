using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Add Numbers

            int value1 = 1234;
            int value2 = 4567;

            Console.WriteLine($"The sum of {value1} and {value2} is: {SumNums(value1, value2)} ");

            int SumNums(int num1, int num2)
            {
                return (num1 + num2);
            }
        }
    }
}
