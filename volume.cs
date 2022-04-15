using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Calculate Volume   width, length, heigh    

            int width = 23;
            int height = 44;
            int length = 32;
            
            Console.WriteLine($"The volume of length {length} and width {width} and height {height} is: {CalculateVolume(length, width, height)} ");

            static int CalculateVolume(int num1, int num2, int num3)
            {
                return ((num1 * num2) * num3);
            }
        }
    }
}