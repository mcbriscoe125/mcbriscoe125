using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {
            string word = "Stinky";
            int count = 5;
            string word2 = "";

            word2 = LetterMultiple(word, count);

            string LetterMultiple(string word1, int count)
            {
                string str1 = "";
                for (int i = 0; i < (word.Length - 1); i++)
                {
                    for (int j = 0; j < count; j++)
                    {
                        str1 += word[i];
                    }
                }

                return str1;
            }

                Console.WriteLine(word2);
        }
        
    }
            
     
}