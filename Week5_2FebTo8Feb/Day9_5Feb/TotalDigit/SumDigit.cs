using System;
using System.Collections.Generic;
using System.Text;

namespace TotalDigit
{
    internal class SumDigit
    {
        public static int sum(string input)
        {
            int res=int.Parse(input);
            int sum = 0;
           // int i = input.Length - 1;
            while (res > 0)
            {
                int rem = res % 10;
                sum += rem;
                res = res / 10;

                

            }
            return sum;
        }
    }
}
