using System;
using System.Text.RegularExpressions;

namespace HashTagExtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read input
            string input = Console.ReadLine();

            // Regex pattern to extract hashtags
            string pattern = @"#\w+";

            MatchCollection matches = Regex.Matches(input, pattern);

            // Print each hashtag on new line
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
