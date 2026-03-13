using System;
using System.Collections.Generic;
using System.Text;

namespace Occurence
{
    internal class CarBike
    {
        public static List<int> getCount(int n,List<List<int>> dealership)
        {
            List<int> result=new List<int>();
            
            for(int i = 0; i < n; i++)
            {
                int cars = dealership[i][0];
                int biks=dealership[i][1];

                result.Add(4 * cars + 2 * biks);
            }
            return result;
        }
    }
}
