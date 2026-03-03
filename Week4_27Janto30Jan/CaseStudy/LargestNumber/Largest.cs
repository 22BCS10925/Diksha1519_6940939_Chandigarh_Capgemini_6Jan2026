using System;

namespace LargestNumber
{
    public class Largest
    {
        public static int largestNumber(int[] input1)
        {
            bool hasNegative = false;
            bool hasZeroOrAbove100 = false;

            // Check business rules
            foreach (int n in input1)
            {
                if (n < 0) hasNegative = true;
                if (n == 0 || n > 100) hasZeroOrAbove100 = true;
            }

            if (hasNegative && hasZeroOrAbove100) return -3;
            if (hasNegative) return -1;
            if (hasZeroOrAbove100) return -2;

            // Array to track largest number in each range
            int[] largest = new int[10];

            // Process elements and ignore duplicates manually
            for (int i = 0; i < input1.Length; i++)
            {
                int current = input1[i];

                // Check if duplicate
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (input1[j] == current)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (isDuplicate) continue;

                // Find bucket index
                int index = (current - 1) / 10; // 1–10 =>0, 11–20=>1...

                // Store largest in that bucket
                if (current > largest[index])
                    largest[index] = current;
            }

            // Sum of largest values
            int sum = 0;
            for (int i = 0; i < largest.Length; i++)
            {
                sum += largest[i];
            }

            return sum;
        }
    }
}
