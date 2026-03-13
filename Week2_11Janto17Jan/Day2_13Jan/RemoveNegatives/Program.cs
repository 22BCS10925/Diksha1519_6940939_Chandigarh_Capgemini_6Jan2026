namespace RemoveNegatives
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the size of an array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] output = new int[n];
            if (n < 0)
            {
                Console.Write("-1");
            }
            for (int i = 0; i < n; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    output[i] = arr[i];
                }

            }
            output.Sort();
            Console.WriteLine("Resulted Array: ");
            for (int i = 0; i < n; i++)
            {
                if (output[i] > 0)
                {
                    Console.Write(output[i]+" ");
                }
            }
        }
    }
}
