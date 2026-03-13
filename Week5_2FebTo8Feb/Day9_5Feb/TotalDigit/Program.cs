namespace TotalDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the digit sum : ");
            string input=Console.ReadLine();
            Console.WriteLine("Sum will be: "+ SumDigit.sum(input));
        }
    }
}
