using System.Text.RegularExpressions;

namespace EmailValid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the mail");
            string input2=Console.ReadLine();
            string input = @"^\w+@\w+\..{3}$";
            if (Regex.IsMatch( input2, input))
            {
                Console.WriteLine("Valid " );
            }
            else
            {
                Console.WriteLine("InValid");
            }
        }
    }
}
