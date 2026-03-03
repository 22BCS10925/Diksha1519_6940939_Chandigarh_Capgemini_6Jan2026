namespace DigitSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the digit: ");
            int digit=int.Parse(Console.ReadLine());

            int sum = 0;
            while (digit>0)
            {
                int rem = digit % 10;
                sum+= rem;
                digit = digit / 10;

            }
            Console.WriteLine("Sum of Digits : " + sum);
        }
    }
}
