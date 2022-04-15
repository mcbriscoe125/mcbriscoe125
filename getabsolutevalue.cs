using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Get Absolute Value         

            int value1 = -66;
            
            Console.WriteLine($"The Absolute Value of value {value1} is: {AbsoluteValue(value1)} ");

            static int AbsoluteValue(int num)
            {
                if (num < 0)
                {
                    return num * -1;
                }
                else
                {
                    return num;
                }
            }
        }
    }
}