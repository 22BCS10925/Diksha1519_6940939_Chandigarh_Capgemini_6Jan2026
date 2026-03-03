using System;
using System.Collections.Generic;
using System.Text;

namespace CountChar
{
    internal class UserProgramCode
    {
        public static int CountTripleRepeat(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length - 2; i++)
            {
                if (input[i] == input[i + 1] && input[i] == input[i + 2])
                {
                    count++;
                    i += 2;
                }
            }
            return count;
        }

    }
}
