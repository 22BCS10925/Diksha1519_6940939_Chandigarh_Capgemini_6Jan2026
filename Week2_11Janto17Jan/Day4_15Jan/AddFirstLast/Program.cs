namespace AddFirstLast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 7, 8, 9, 10, 11, 12 };
            int size = arr1.Length;
            int[] output = new int[size];

            
            if (size < 0)
            {
                output = new int[1];
                output[0] = -2;
                Console.WriteLine(output[0]);
                return;
            }

           
            for (int i = 0; i < size; i++)
            {
                if (arr1[i] < 0 || arr2[i] < 0)
                {
                    output[0] = -1;
                    Console.WriteLine(output[0]);
                    return;
                }
            }

            
            int left = 0;
            int right = size - 1;

            while (left < size)
            {
                output[left] = arr1[left] + arr2[right];
                left++;
                right--;
            }

           
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
