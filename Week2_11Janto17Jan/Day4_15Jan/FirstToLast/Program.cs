namespace FirstToLast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size for array: ");
            int n = int.Parse(Console.ReadLine());
           
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int size = n;
            int[] output = new int[size];
            Console.Write("Enter the elements for arr1: ");
            for(int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the elements for  arr2: ");
            for (int i = 0; i < n; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            if (size < 0)
            {
                output = new int[1];
                output[0] = -2;
                Console.WriteLine(output[0]);
                return;
            }


            for (int i = 0; i < n; i++)
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

            Console.WriteLine("Resulted array will be: ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
