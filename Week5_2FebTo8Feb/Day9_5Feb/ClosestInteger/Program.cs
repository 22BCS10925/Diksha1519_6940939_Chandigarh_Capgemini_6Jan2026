namespace ClosestInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


                Console.Write("Enter a positive integer: ");
                int n = int.Parse(Console.ReadLine());

                int root = (int)Math.Sqrt(n);

                int lowerSquare = root * root;
                int higherSquare = (root + 1) * (root + 1);

                int result = (n - lowerSquare <= higherSquare - n)
                             ? lowerSquare
                             : higherSquare;

                Console.WriteLine("Closest integer having whole number square root: " + result);
            }
        }


}
