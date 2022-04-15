using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {
            int[] valueList = new[] { 12, 34, 43, 45, 66, 76, 87, 9, 101, 33, 88 };
            
            int minVal = MinimumValue(valueList); 
            int maxVal = MaximumValue(valueList);

            int MinimumValue(int[] list)
            {
                int minVal = list[0];
                foreach (int digit in list)
                {
                    if (digit < minVal)
                    {
                        minVal = digit;
                    }
                }
                return minVal;
            }

            int MaximumValue(int[] list)
            {
                int maxVal = 0;
                foreach (int digit in list)
                {
                    if (digit > maxVal)
                    {
                        maxVal = digit;
                    }
                }
                return maxVal;
            }

            Console.WriteLine($"The minimum value is:  {minVal} an the maximun value is:  {maxVal}");
        }
        
    }
            
     
}