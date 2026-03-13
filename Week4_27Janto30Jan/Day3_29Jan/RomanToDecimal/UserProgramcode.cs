using System;
using System.Collections.Generic;
using System.Text;

namespace RomanToDecimal
{
    internal class UserProgramcode
    {
        public static int getDecimal(string input)
        {
           Dictionary<char,int> result = new Dictionary<char, int> {
               { 'I' , 1 },
               { 'V' , 5},
               {'X',10 },
               {'L',50 },
               {'C',100 },
               {'D',1000 }



            };
            input = input.ToUpper();
            int total = 0;
            for(int i = 0; i < input.Length; i++)
            {
                int current = result[input[i]];
                if (i+1<input.Length && current < result[input[i + 1]])
                {
                    total += result[input[i + 1]] - current;
                    i++;
                }
                else
                {
                    total+= current;
                }
            }

            return total;
        }
    }
}
