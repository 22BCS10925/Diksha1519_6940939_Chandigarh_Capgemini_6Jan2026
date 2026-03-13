namespace SumArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int even=0, odd=0;
            int output1 = 0;
            Console.WriteLine("Enter the number of values you want to add: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            if (n < 0)
            {
                output1 = -2;
            }
            for(int i = 0; i < n; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    output1 = -1;
                    Console.WriteLine(output1);
                    return;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]); 
            }
            for(int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even += arr[i];
                }
                else 
                {
                    odd += arr[i];
                }

            }
            Console.WriteLine("Sum of even number is :" + even);
           
            Console.WriteLine("Sum of odd number is :" + odd);
            output1 = (even + odd) / 2;
            Console.WriteLine(output1);



        }
    }
}
