using System;
using System.Collections.Generic;
using System.Text;

namespace DigitSum
{
    internal class UserProgramCode
    {
        public static int getSum(string[] input)
        {
            int sum = 0;
            for(int i = 0; i < input.Length; i++)
            {
                foreach(char c in input[i])
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        return -2;
                    }
                    if (char.IsDigit(c))
                    {
                        sum += c - '0';
                    }
                }
            }

            return sum;
        }
    }
}
