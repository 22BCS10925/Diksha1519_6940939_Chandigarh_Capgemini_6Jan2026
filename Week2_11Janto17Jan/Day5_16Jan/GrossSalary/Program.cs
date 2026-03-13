
namespace GrossSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Basic Salary:");
            double basic = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number of Working Days:");
            int days = int.Parse(Console.ReadLine());

            double output;

            if (basic < 0)
            {
                output = -1;
            }
            else if (basic > 10000)
            {
                output = -2;
            }
            else if (days > 31)
            {
                output = -3;
            }
            else
            {
                double da = 0.75 * basic;
                double hra = 0.50 * basic;
                output = basic + da + hra;
            }

            Console.WriteLine("Output: " + output);
        }
    }
}
