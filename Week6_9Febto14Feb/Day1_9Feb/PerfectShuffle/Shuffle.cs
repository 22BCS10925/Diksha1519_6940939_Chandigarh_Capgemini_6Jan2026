using System;
using System.Collections.Generic;
using System.Text;

namespace PerfectShuffle
{
    internal class Shuffle
    {
        public static bool IsPerfectShuffle(string x, string y, string z)
        {
            if (x.Length + y.Length != z.Length) return false;

            int i = 0, j = 0;

            foreach (char c in z)
            {
                if (i < x.Length && c == x[i]) i++;
                else if (j < y.Length && c == y[j]) j++;
                else return false;
            }
            return i == x.Length && j == y.Length;
        }

    }
}
