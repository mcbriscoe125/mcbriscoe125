using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {  // Calculate Perimeter Of Rectangle  


            int length1 = 5;
            int width = 8;

            Console.WriteLine($"The Primeter of the rectangl  is {GetPerimeter(length1, width)}.");
        }

        static int GetPerimeter(int len1, int wid2)
        {
            return ((len1 * 2) + (wid2 * 2));
        }
    }
}
