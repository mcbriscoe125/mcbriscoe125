using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Convert An Age To Days  

            int age = 50;

            Console.WriteLine($"The number of days for age {age} is {AgeToDays(age)}");
           int AgeToDays(int age1)
            {
                return (age1 * 365);
            }

        }
    }
}