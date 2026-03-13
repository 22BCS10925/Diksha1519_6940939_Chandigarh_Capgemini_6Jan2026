using System.Text;

namespace LongestNon_Decreasing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "110010";
            int n = s.Length;

            List<string> pairs = new List<string>();

            for (int i = 0; i < n; i += 2)
                pairs.Add(s.Substring(i, 2));

            pairs.Sort(); // sorts as 00,01,10,11

            StringBuilder sb = new StringBuilder();
            foreach (var p in pairs)
                sb.Append(p);

            string rearranged = sb.ToString();

            int maxLen = 1, curr = 1;
            for (int i = 1; i < rearranged.Length; i++)
            {
                if (rearranged[i] >= rearranged[i - 1])
                    curr++;
                else
                    curr = 1;

                maxLen = Math.Max(maxLen, curr);
            }

            Console.WriteLine(maxLen);
        }
    }

}
