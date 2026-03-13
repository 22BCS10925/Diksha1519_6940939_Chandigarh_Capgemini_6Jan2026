using System;
using System.Collections.Generic;
using System.Text;

namespace Occurence
{
    internal class StringRotate
    {
        public static bool CheckRotate(string input1, string input2)
        {
            //if (input1 == null || input2 == null)
            //{
            //    return false;
            //}
            if (input1.Length != input2.Length)
            {
                return false;
            }

            string temp = input1 + input1;


            return temp.Contains(input2);

            
        }
    }
}
