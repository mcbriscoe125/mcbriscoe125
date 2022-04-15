using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Convert Minutes To Seconds      

            int minutes = 23;
            
            Console.WriteLine($"The nnumber of seconds for {minutes} minutee is: {MinutesToSeconds(minutes)} ");

            static int MinutesToSeconds(int min)
            {
                return min * 60;
            }
        }
    }
}