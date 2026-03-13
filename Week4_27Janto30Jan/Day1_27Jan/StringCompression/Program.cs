using System;

namespace StringCompression
{
    internal class Program
    {
        public static string Compression(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            char[] res = new char[str.Length]; 
            int ind = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                int cnt = 1;

               
                while (i + 1 < str.Length && str[i + 1] == ch)
                {
                    cnt++;
                    i++;
                }

               
                res[ind++] = ch;

               
                if (cnt > 1)
                {
                    string cntStr = cnt.ToString();
                    foreach (char c in cntStr)
                    {
                        res[ind++] = c;
                    }
                }
            }

            Array.Resize(ref res, ind);
            return new string(res);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();

            string result = Compression(str);
            Console.WriteLine("After Compression: " + result);
        }
    }
}
