using System;
using System.Collections.Generic;
using System.Text;

namespace TwoSum
{
    internal class getSum
    {
        public static List<int> Sum(int[] arr,int target)
        {
            List<int> list = new List<int>();   
            int l = 0;
            int r=arr.Length - 1;
            while (l < r)
            {
                int sum = arr[l] + arr[r];
                if ( sum == target)
                {
                    list.Add(l);
                    list.Add(r);
                    break;
                    
                }
                if (sum > target)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }
            Console.WriteLine("Index Value: ");
            foreach(int i in list)
            {
                Console.Write(i);
            }


            return list;
        }
    }
}
