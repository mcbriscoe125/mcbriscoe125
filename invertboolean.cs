using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        private static void Main(string[] args)
        {  // Invert Boolean  


            bool bvalue = true;

            Console.WriteLine($"The Inversion of {bvalue} is {InvertBool(bvalue)}.");
        }

        static bool InvertBool(bool val)
        {
            return !val;
        }
    }
}