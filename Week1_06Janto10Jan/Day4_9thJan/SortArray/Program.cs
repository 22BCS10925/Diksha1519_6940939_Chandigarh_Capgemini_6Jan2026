namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] output = new int[Math.Max(size, 1)];

            // Condition 2: negative size
            if (size < 0)
            {
                output[0] = -2;
                Console.WriteLine(output[0]);
                return;
            }

            int[] input1 = new int[size];
            int[] input2 = new int[size];

            Console.WriteLine("Enter elements of first array:");
            for (int i = 0; i < size; i++)
            {
                input1[i] = int.Parse(Console.ReadLine());
                if (input1[i] < 0)
                {
                    output[0] = -1;
                    Console.WriteLine(output[0]);
                    return;
                }
            }

            Console.WriteLine("Enter elements of second array:");
            for (int i = 0; i < size; i++)
            {
                input2[i] = int.Parse(Console.ReadLine());
                if (input2[i] < 0)
                {
                    output[0] = -1;
                    Console.WriteLine(output[0]);
                    return;
                }
            }

            // Sort input1 ascending
            Array.Sort(input1);

            // Sort input2 descending
            Array.Sort(input2);
            Array.Reverse(input2);

            
            for (int i = 0; i < size; i++)
            {
                output[i] = input1[i] * input2[size - 1 - i];
            }

            Console.WriteLine("Output array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(output[i] + " ");
            }
        }
    }
}
