using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Divides Evenly        

            int value1 = 66;
            
            Console.WriteLine($"The provided value {value1} is evenly divisibl: {IsEvenlyDivisible(value1)} ");

            static bool IsEvenlyDivisible(int num)
            {
                if (num % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}