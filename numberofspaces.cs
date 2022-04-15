using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Get Number Of Spaces        

            string sentence = "The dirty bird took a birdbath";
            
            Console.WriteLine($"The number of spaces in {sentence} is: {GetNumOfSpaces(sentence)} ");

            static int GetNumOfSpaces(string sen)
            {
                int count = 0;
                for (int i = 0; i <= sen.Length - 1; i++)  
                {
                    if (sen[i] == ' ')
                    count++;
                }
                return count;
            }
        }
    }
}