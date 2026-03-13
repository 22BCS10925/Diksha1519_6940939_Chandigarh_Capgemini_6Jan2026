namespace ValidWords
{
    internal class Program
    {
        static bool IsValidWord(string word)
        {
            if (word.Length <= 2) return false;

            bool hasVowel = false, hasConsonant = false;

            foreach (char c in word)
            {
                if (!char.IsLetterOrDigit(c))
                    return false;

                if (char.IsLetter(c))
                {
                    if ("aeiouAEIOU".Contains(c))
                        hasVowel = true;
                    else
                        hasConsonant = true;
                }
            }
            return hasVowel && hasConsonant;
        }
        static void Main(string[] args)
        {

            string input = "hello a1 bcd 12@ code";
            string[] words = input.Split(' ');

            int count = 0;
            foreach (string w in words)
                if (IsValidWord(w))
                    count++;

            Console.WriteLine(count);
        }
    }

}
