using System.Text.RegularExpressions;

namespace PhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Phone Number: ");
            string[] num = new string[size];
            for (int i = 0; i < size; i++)
            {
                num[i] = Console.ReadLine();
            }
            string digit = @"^\+91\d{10}$";
            //MatchCollection match = Regex.Matches(num, digit);
            for (int i = 0; i < size; i++)
            {
                if (Regex.IsMatch(num[i], digit))
                {
                    Console.WriteLine(num[i] + " → Valid");
                }
                else
                {
                    Console.WriteLine(num[i] + " → Invalid");
                }
            }
        }
    }
}
