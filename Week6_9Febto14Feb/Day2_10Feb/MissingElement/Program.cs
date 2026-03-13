namespace MissingElement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 4, 5, 6 };

            int n = arr.Length + 1;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = arr.Sum();

            Console.WriteLine(expectedSum - actualSum);
        }
    }

}
