namespace CountCouple
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 24, 11, 8, 3, 16 };
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                bool divisible = false;

                for (int j = 0; j < A.Length; j++)
                {
                    if (i != j && A[i] % A[j] == 0)
                    {
                        divisible = true;
                        break;
                    }
                }

                if (!divisible)
                    count++;
            }

            Console.WriteLine(count);
        }
    }

}
