using System;

namespace ConsoleApp
{
   internal class Program
   {
       private static void Main(string[] args)
       {
           string version = "9.8.7";
           string majorVersionNumber = GetMajorVersionNumber(version);

           Console.WriteLine($"The Major number is {majorVersionNumber}");
       }

       private static string GetMajorVersionNumber(string version)
       {
           string[] versionArr = version.Split(".");

           string versionStr = versionArr[0];

           return versionStr;
       }
   }
}