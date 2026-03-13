using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSize
{
    internal class MinMax
    {
        public static int getStrength(int[] skill, int[] teamSize)
        {
            Array.Sort(skill);
            int left = 0;
            int right = skill.Length - 1;
            int totalStrength = 0;
            //int count = 0;
            int sum = teamSize.Length - 1;

            foreach (int size in teamSize)
            {
                if (sum != skill.Length - 1)
                {
                    return 0;
                }
                
                int min = skill[left];
                int max = skill[right];

                totalStrength += min + max;

                left++;
                right--;

                left += size - 2;
            }
               
            return totalStrength;
        }
    }
}
