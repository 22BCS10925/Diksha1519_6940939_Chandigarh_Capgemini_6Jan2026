namespace SquareOfOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n=int.Parse(Console.ReadLine());

            int digit=0;
            int output = 0;

            if (n < 0)
            {
                output = -1;
            }
            while (n > 0)
            {
                digit = n % 10;
                if (digit % 2 != 0)
                {
                    output += digit*digit;
                }
                n = n / 10;
            }
            Console.WriteLine(output);
        }
    }
}
