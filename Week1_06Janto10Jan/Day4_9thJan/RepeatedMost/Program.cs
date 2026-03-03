namespace RepeatedMost;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 2, 2, 2, 3, 3, 3, 3, 4 };

        int maxCount = 0;

        // Find maximum frequency
        for (int i = 0; i < arr.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                    count++;
            }
            if (count > maxCount)
                maxCount = count;
        }

        // Print elements with max frequency
        Console.Write("Output: { ");
        for (int i = 0; i < arr.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                    count++;
            }
            if (count == maxCount)
            {
                Console.Write(arr[i] + " ");
                for (int k = i + 1; k < arr.Length; k++)
                    if (arr[i] == arr[k]) i = k;
            }
        }
        Console.WriteLine("}");
    }
}
