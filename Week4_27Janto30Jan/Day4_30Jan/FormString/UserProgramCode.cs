using System;
using System.Collections.Generic;
using System.Text;

public class UserProgramCode
{
    public static string formString(string[] input1, int input2)
    {
        string result = "";

        foreach (string str in input1)
        {
            // Check for special characters
            foreach (char ch in str)
            {
                if (!char.IsLetter(ch))
                {
                    return "-1";
                }
            }

            // Pick nth character (1-based index)
            if (input2 <= str.Length)
                result += str[input2 - 1];
            else
                result += "$";
        }

        return result;
    }
}