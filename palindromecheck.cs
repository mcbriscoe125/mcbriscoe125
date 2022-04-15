using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {
            string word = "toilet";
            bool isTrue = IsPalindrome(word);

            bool IsPalindrome(string word1)
            {
                string word2 = "";
                for (int i = (word1.Length - 1); i >= 0; i--)
                {
                    word2 += word1[i];
                }
                if (word2 == word1)
                {
                    Console.WriteLine($"{word1} is a palindrome");
                    return true;
                } 
                 else
                {
                    Console.WriteLine($"{word1} is not a palindrome");
                    return false;
                }
                
            }
        }
    }
}