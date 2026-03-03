using System;

namespace ProductOfthreeOrFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int result;

            if (num < 0)
            {
                result = -1;   // negative number
            }
            else if (num % 3 == 0 || num % 5 == 0)
            {
                result = 1;    // divisible by 3 or 5
            }
            else
            {
                result = -2;   // positive but not divisible
            }

            Console.WriteLine(result);
        }
    }
}
