using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Get Minor Version Number      

            string version = "9.8.7";
            
            Console.WriteLine($"The minor version numbeer of {version} is: {GetMinorVersion(version)} ");

            static char GetMinorVersion(string ver)
            {
                char minor = ver[ver.Length - 1];

                return minor;
            }
        }
    }
}
