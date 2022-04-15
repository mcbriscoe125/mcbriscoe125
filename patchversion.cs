using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Get Patch Version Number          

            string version = "16.8.32";
            
            Console.WriteLine($"The patch number in {version} is: {GetPatch(version)} ");

            static string GetPatch(string ver)
            {
                int firstDotIndex = ver.IndexOf(".");
                int secondDotIndex = ver.IndexOf(".", firstDotIndex + 1);
                string patch = ver.Substring(secondDotIndex + 1);
                return patch;
            }
        }
    }
}