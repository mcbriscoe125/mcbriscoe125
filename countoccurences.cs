using System;

namespace C_SharpFunctionsCourse
{
    internal class Program
    {
        public static void Main(string[] argd)
        {  //  Count Letter Occurrences Of A Letter In A Sentence  
            string word = "toilet";
            char letter = 't';

            int letterCount = LetterCount(word, letter);

            Console.WriteLine($"The number of occurences of {letter} in {word} is {letterCount}");
            
            static int LetterCount(string word1, char letter1)
            {
                int counter = 0;
                foreach (char let in word1)
                {
                    if (let == letter1)
                    {
                        counter += 1;
                    }
                }

                return counter;
            }

            
        }
    }
}
