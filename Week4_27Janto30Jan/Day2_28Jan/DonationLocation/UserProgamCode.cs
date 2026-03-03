using System;
using System.Collections.Generic;
using System.Text;

namespace DonationLocation
{
    internal class UserProgamCode
    {
        public static int getDonation(string[] str,int input2)
        {
            int n = str.Length;
            for (int i = 0; i < n; i++)
            {
                foreach (char c in str[i])
                {
                    if (!char.IsDigit(c))
                    {
                        return -2;

                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                int usercode = int.Parse(str[i].Substring(0, 3));
                for (int j = i + 1; j < n; j++)
                {
                    int user = int.Parse(str[j].Substring(0, 3));
                    if (usercode == user)
                    {
                        return -1;
                    }
                }
            }
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                int location = int.Parse(str[i].Substring(3, 3));
                int donation = int.Parse(str[i].Substring(6, 3));
                if (location == input2)
                {
                    sum += donation;

                }
            }
            return sum;
        }
        
    }
}
