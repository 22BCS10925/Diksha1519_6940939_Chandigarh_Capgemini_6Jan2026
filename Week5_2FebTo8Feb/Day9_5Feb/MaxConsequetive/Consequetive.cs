using System;
using System.Collections.Generic;

namespace MaxConsequetive
{
    internal class Consequetive
    {
        public static int MaxDeletions(string input)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            // Count frequency of each character
            foreach (char c in input)
            {
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }

            int deletions = 0;

            // Each pair gives one deletion
            foreach (var item in freq)
            {
                deletions += item.Value / 2;
            }

            return deletions;
        }

    }
}
