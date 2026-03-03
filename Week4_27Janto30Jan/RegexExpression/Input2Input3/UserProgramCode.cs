using System;
using System.Collections.Generic;
using System.Text;

namespace Input2Input3
{
    internal class UserProgramCode
    {
        public static int CheckOrder(string input1, string input2, string input3)
        {
            int idx2 = input1.IndexOf(input2);
            int idx3 = input1.IndexOf(input3);

            if (idx2 != -1 && idx3 != -1 && idx3 > idx2)
                return 1;
            return -1;
        }

    }
}
