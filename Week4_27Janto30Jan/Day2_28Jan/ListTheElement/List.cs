using System;
using System.Collections.Generic;
using System.Text;

namespace ListTheElement
{
    internal class List
    {
        public static List<int> GetElements(List<int> li, int n, int input2)
        {
            List<int> el = new List<int>();

            // Prevent index out of range
            int limit = Math.Min(n, li.Count);

            for (int i = 0; i < limit; i++)
            {
                if (li[i] < input2)
                {
                    el.Add(li[i]);
                }
                
                
            }
            if (el.Count == 0)
            {
                return new List<int> { -1 };
            }
            el.Sort();
            el.Reverse();


            return el;
        }

    }
}
