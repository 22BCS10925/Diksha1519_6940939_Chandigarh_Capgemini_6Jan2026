using System;
using System.Collections.Generic;
using System.Text;

namespace MaxDifference
{
    internal class Difference
    {
        public static int Diff(int[] arr1,int n)
        {
            int maxDiff = -1;
            //int Diff = 0;
            if (n < 0 || n > 10)
            {
                return -2;
            }
          
            for(int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++) 
                {
                    if (arr1[i] == arr1[j])
                    {
                        return -3;
                    }
                    if (arr1[j] > arr1[i])
                    {
                        int Diff = arr1[j] - arr1[i];
                        maxDiff = Math.Max(maxDiff, Diff);
                    }
                }
                
            }
           
            return maxDiff;
        }
    }
}
