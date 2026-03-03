using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

using System.Text.RegularExpressions;

namespace DateYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)	Adding years to date. If date format is wrong return -1.If years given is negative return -2
            string pattern = @"^([0]{1-9}|12[0-9]|3[01])/(0[0-9]|1[0-2])|/\d{4}$";
            string input = Console.ReadLine();
            Console.WriteLine("Add date to Year: ");
            int yearToAdd=int.Parse(Console.ReadLine());
            if (!Regex.IsMatch(input,pattern))
                {
                Console.WriteLine("-2");
                }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}
