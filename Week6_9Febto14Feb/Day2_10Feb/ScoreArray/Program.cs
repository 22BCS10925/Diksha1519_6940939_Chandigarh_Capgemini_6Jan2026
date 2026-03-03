namespace ScoreArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4 };
            int score = 0;

            // Couples
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] + arr[i + 1]) % 2 == 0)
                    score += 5;
            }

            // Triplets
            for (int i = 0; i < arr.Length - 2; i++)
            {
                int sum = arr[i] + arr[i + 1] + arr[i + 2];
                int product = arr[i] * arr[i + 1] * arr[i + 2];

                if (sum % 2 != 0 && product % 2 == 0)
                    score += 10;
            }

            Console.WriteLine(score);
        }
    }

}
