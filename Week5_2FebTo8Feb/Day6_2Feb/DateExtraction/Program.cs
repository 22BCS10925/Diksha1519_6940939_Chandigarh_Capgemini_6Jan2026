using System.Text.RegularExpressions;

namespace DateExtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Date: ");
            string date=Console.ReadLine();

            string pattern = @"^0[1-9]|12[0-9]|3[01]/0[1-9]|1[0-2]/\d{4}$";
            if (Regex.IsMatch(date, pattern))
            {
                Console.WriteLine("Valid Date");
            }
            else
            {
                Console.WriteLine("Invalid Date");
            }
        }
    }
}
