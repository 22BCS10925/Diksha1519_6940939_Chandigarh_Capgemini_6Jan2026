using System.Text.RegularExpressions;

namespace StrongPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you password: ");
            string password=Console.ReadLine();

            string match = @"^(?=.*\d)(?=.*\w[A-Z])(?=.*\w[a-z])(?=.*[@$#%&]){8,}"; 
            if (Regex.IsMatch(password, match))
            {
                Console.WriteLine("Strong Paasword");
            }
            else
            {
                Console.WriteLine("Weak Password");
            }
        }
    }
}
