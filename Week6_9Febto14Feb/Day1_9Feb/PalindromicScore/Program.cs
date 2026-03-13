namespace PalindromicScore;

class Program
{
    static bool IsPalindrome(string s)
    {
        int l = 0, r = s.Length - 1;
        while (l < r)
            if (s[l++] != s[r--]) return false;
        return true;
    }

    static void Main(string[] args)
    {
        string s = "ABCBAAAA";
        int score = 0;

        for (int i = 0; i <= s.Length - 4; i++)
            if (IsPalindrome(s.Substring(i, 4)))
                score += 5;

        for (int i = 0; i <= s.Length - 5; i++)
            if (IsPalindrome(s.Substring(i, 5)))
                score += 10;

        Console.WriteLine(score);
    }
}
