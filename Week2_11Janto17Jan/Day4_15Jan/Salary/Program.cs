
namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the salary of a person:");
            int salary = int.Parse(Console.ReadLine());

            
            if (salary > 9000)
            {
                Console.WriteLine("-1");
                return;
            }

            Console.WriteLine("Enter the expenses spent on food & travel (in %):");
            float expen = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the days he works:");
            int days = int.Parse(Console.ReadLine());

            
            if (days <= 0)
            {
                Console.WriteLine("-4");
                return;
            }

            int savings;

            float expenseAmount = (salary * expen) / 100;

          
            savings = (int)(salary - expenseAmount);

            
            if (days == 31)
            {
                savings += 500;
            }

            Console.WriteLine("Savings: " + savings);
        }
    }
}
