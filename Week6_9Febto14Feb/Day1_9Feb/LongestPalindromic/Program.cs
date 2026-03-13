namespace LongestPalindromic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 1;
            string s = "babad";

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    string sub = s.Substring(i, j - i + 1);
                    if (sub.SequenceEqual(sub.Reverse()))
                        max = Math.Max(max, sub.Length);
                }
            }
            Console.WriteLine(max);

        }
    }
}
