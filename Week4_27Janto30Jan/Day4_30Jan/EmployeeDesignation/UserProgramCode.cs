using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDesignation
{
    internal class UserProgramCode
    {
        public static string[] getEmployee(string[] input1, string input2)
        {
            int n = input1.Length;
            string[] res = new string[n];
            int count = 0;   // to track matched employees

            // Validation: only alphabets
            for (int i = 0; i < n; i++)
            {
                foreach (char c in input1[i])
                {
                    if (!char.IsLetter(c))
                    {
                        return new string[] { "Invalid Input" };
                    }
                }
            }

            // Logic to find employees for given designation
            for (int i = 1; i < n; i += 2)
            {
                if (input1[i].Equals(input2, StringComparison.OrdinalIgnoreCase))
                {
                    res[count++] = input1[i - 1];
                }
            }

            // Business rules
            if (count == 0)
            {
                return new string[] { $"No employee for {input2} designation" };
            }

            if (count == n / 2)
            {
                return new string[] { $"All employees belong to same {input2} designation" };
            }

         
            string[] finalRes = new string[count];
            for (int i = 0; i < count; i++)
            {
                finalRes[i] = res[i];
            }

            return finalRes;
        }
    }
}
