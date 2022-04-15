using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Convert String Number To Integer      

            string value1 = "2345";
            
            Console.WriteLine($"The converted sting value is: {StringToInt(value1)} ");

            static int StringToInt(string min)
            {
                int min2 = Int32.Parse(min);
                return min2;
            }
        }
    }
}