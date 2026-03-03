namespace CountCouples
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
                int N = int.Parse(Console.ReadLine());
                int[] arr = new int[N];

                for (int i = 0; i < N; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int count = 0;

                for (int i = 0; i < N - 1; i++)
                {
                    if ((arr[i] + arr[i + 1]) % N == 0)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
        }

    }

