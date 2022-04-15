using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
           private static void Main(string[] args)
        {
            string word = "funny";
            string word2 = ReverseWord(word);

            string ReverseWord(string word1)
            {
                string revWord = "";
                for(int i = (word1.Length -1); i >= 0; i--)
                {
                   revWord += word1[i];
                }
                return revWord;
            }
            Console.WriteLine(word);
            Console.WriteLine(word2);
        }

       
    }
}