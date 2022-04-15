using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Compute The Absolute Sum Of An Array   

            int[] numGroup = new[] { 12, 13, 23, 25, 45, 65, 7, 58, 99, 100 };

            Console.WriteLine($" The absolute sum is {ArraySum(numGroup)}");

            int ArraySum(int[] group1)
            {
                int sum = 0;
                for (int i = 0; i < group1.Length; i++)
                {
                    sum += group1[i];
                }

                return sum;
            }
        }
    }
}
