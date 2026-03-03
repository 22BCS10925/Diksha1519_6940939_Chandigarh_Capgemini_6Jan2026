using System;
using System.Collections.Generic;
using System.Text;

namespace CountElements
{
    public class UserProgramCode
    {
        public static int GetCount(int size, string[] input1, char input2)
        {
            int count = 0;

            // Check Rule 2: Only alphabets in input1 strings
            foreach (string s in input1)
            {
                foreach (char c in s)
                {
                    if (!char.IsLetter(c))
                        return -2;
                }
            }

            // Convert input2 to lowercase for case-insensitive compare
            char ch = char.ToLower(input2);

            foreach (string s in input1)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    if (char.ToLower(s[0]) == ch)
                        count++;
                }
            }

            // Rule 1: If no matches found
            if (count == 0)
                return -1;

            return count;
        }
    }
}

   