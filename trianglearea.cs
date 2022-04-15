using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Area Of Triangle      

            int height = 7;
            int based = 5;
            
            Console.WriteLine($"The area of the triangle height {height} and base {based} is: {Area(height, based)} ");

            static int Area(int num1, int num2)
            {
                return num1 * num2;
            }
        }
    }
}