using System;

namespace ConsoleApp
{
   internal class Program
   {
       private static void Main(string[] args)
       {
           string url = @"https://www.reddit.com/r/funny/";

           string subreddit = GetSubReddit(url);

           Console.WriteLine($"The subreddit is {subreddit}.");
       }

       private static string GetSubReddit(string url)
       {
           string[] urlArr = url.Split("https://www.reddit.com/r/");

           urlArr[1] = urlArr[1].Replace("/", "");

           string subreddit = urlArr[1];

           return subreddit;
       }
   }
}