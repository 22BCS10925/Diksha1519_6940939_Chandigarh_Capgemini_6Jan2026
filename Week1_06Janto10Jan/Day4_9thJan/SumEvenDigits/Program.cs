namespace SumEvenDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int output = 0;
            int digit;

            Console.WriteLine("Enter a number:");
            number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                output = -1;
            }
            else if (number > 32767)
            {
                output = -2;
            }
            else
            {
                while (number > 0)
                {
                    digit = number % 10;

                    if (digit % 2 == 0)
                    {
                        output += digit;
                    }

                    number /= 10;
                }
            }

            Console.WriteLine(output);
        }
    }
}