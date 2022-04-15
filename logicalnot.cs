using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Logical NOT         

            int num1 = 0;
            int num2 = 1;
            
            Console.WriteLine($"The logical NOT of {num1} and {num2} is: {GetLogicalNot(num1, num2)} ");

            static bool GetLogicalNot(int num1, int num2)
            {
                bool boolNum1 = Convert.ToBoolean(num1);
                bool boolNum2 = Convert.ToBoolean(num2);

                if (!boolNum1 && !boolNum2)
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
