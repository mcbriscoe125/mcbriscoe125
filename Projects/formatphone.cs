using System;

namespace C_SharpFunctionsCourse
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string phoneNum = "13019778892" ;
            string sub1 = phoneNum[0] + "-";
            string sub2 = "";
            for (int i=1; i <=3; i++)
            {
                sub2 += phoneNum[i];
            }
            sub2 = "(" + sub2 + ")" + "-";
            string sub3 = "";
            for(int i = 4; i <= 6; i++)
            {
                sub3 += phoneNum[i];
            }
            sub3 = sub3 + "-";
            string sub4 = "";
            for(int i = 7; i <= 10; i++)
            {
                sub4 += phoneNum[i];
            }
            string sub5 = sub1 + sub2 + sub3 + sub4;
            
            Console.WriteLine($"The formatted sting is:  {sub5}");
        }
    }
}
