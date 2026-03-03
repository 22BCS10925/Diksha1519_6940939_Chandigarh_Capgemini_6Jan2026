namespace DeleteConsequtiveVowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "beautiful";
            int count = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if ("aeiou".Contains(s[i]) && "aeiou".Contains(s[i + 1]))
                {
                    count++;
                    i++; // skip next
                }
            }
            Console.WriteLine(count);

        }
    }
}
