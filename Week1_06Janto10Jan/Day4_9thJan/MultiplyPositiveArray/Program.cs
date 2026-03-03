namespace MultiplyPositiveArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int n =int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0; i<n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int output1 = 1;

            foreach(int x in arr)
            {
                if (x > 0)
                {
                    output1 *= x;

                }
                else
                {
                    output1 = 1;
                }
            }
            Console.WriteLine(output1);

        }
    }
}
