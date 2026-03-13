using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiffDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the date1: ");
            string date1=Console.ReadLine();
            Console.WriteLine("Enter the date2: ");
            string date2=Console.ReadLine();

            DateTime d1 = DateTime.ParseExact(date1, "dd/MM/yyyy", null);
            DateTime d2 = DateTime.ParseExact(date2, "dd/MM/yyyy", null);

            int diff = (d2 - d1).Days;
            Console.WriteLine(diff);


        }
    }
}
//string pattern = @"(\d{2})/\d{2}/\d{4}";

//MatchCollection m = Regex.Matches(date1, pattern);
//MatchCollection m1 = Regex.Matches(date1, pattern);
//int date = 0;
//int dat2 = 0;

//foreach (Match M in m)
//{
//    date = int.Parse(M.Groups[1].Value);

//}
//foreach (Match M in m1)
//{
//    dat2 = int.Parse(M.Groups[1].Value);

//}
//int differnce = dat2 - date;
//Console.WriteLine(differnce);
