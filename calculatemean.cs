using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Calculate The Mean Of An Enumerable  
            int[] array1 = new int[] { 1, 2, 3, 34, 5, 6, 7 };

            Console.WriteLine($"The mean is {GetMean(array1)}");

            static decimal GetMean(int[] group1)
            { 
                decimal mean = 0.0m;
                for (int i = 0; i <= (group1.Length - 1); i++)
                {
                    mean += group1[i];
                }
                return (mean / group1.Length);
            }
        }
    }
}