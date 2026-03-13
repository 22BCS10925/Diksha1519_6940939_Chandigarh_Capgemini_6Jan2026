namespace SumOfMultiplesOf5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of an array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            int avg = 0;
            int count = 0;
            if (n < 0)
            {
                Console.Write("-2");
            }
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach(int i in arr)
            {
                if (i < 0)
                {
                    Console.Write(-1);
                }
                if (i % 5 == 0)
                {
                    sum += i;
                    count++;
                    

                }
            }
            avg = sum;
            avg /= count;

            Console.WriteLine("Sum of Multiples of five: "+sum);
            Console.WriteLine("Average will be: "+avg);
        }
    }
}
