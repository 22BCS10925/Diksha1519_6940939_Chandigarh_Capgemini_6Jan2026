namespace PlotEvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size :");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int output = 0;
            int even = 0;
            int odd = 0;
            if (n < 0)
            {
                Console.WriteLine("-2");
            }

            Console.WriteLine("Enter the elements");
            for(int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    output = -1;
                }
                arr[i]=int.Parse(Console.ReadLine());
            }
            int count = 0;
            int c2 = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even+= arr[i];
                    count++;
                }
                if (arr[i] % 3 == 0)
                {
                    odd += arr[i];
                    c2++;
                }
            }
            int avgeven=even/count;
            int avgodd = odd / c2;

            Console.WriteLine("His Password is: " + avgeven + avgodd);
        }
    }
}
