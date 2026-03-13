using System;

namespace LuckyString
{
    internal class LuckyCheck  
    {
        public string Valid(int len, string[] value)
        {
            int count = 0;

            for (int i = 0; i < len; i++)
            {
                if (value[i] == "P" || value[i] == "S" || value[i] == "G")
                {
                    count++;
                }
            }

            if (count > len / 2)
                return "Yes";
            else
                return "False";
        }
    }
}
