using System;

namespace AnagramCheck
{
    internal class Program
    {
        public static bool Anagram(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return false;

            if (str1.Length != str2.Length)
                return false;

            char[] res1 = str1.ToLower().ToCharArray();
            char[] res2 = str2.ToLower().ToCharArray();

            Array.Sort(res1);
            Array.Sort(res2);

            for (int i = 0; i < res1.Length; i++)
            {
                if (res1[i] != res2[i])
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string 1:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter string 2:");
            string str2 = Console.ReadLine();

            bool res = Anagram(str1, str2);
            Console.WriteLine("Are Anagrams? " + res);
        }
    }
}
