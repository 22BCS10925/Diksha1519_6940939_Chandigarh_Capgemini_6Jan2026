
namespace CaseStudy.Class_member

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Manager manager = new Manager();

            while (true)
            {
                Console.WriteLine("\n===== COLLEGE MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. Add New Student");
                Console.WriteLine("2. Pay Fees");
                Console.WriteLine("3. Enter MST Marks");
                Console.WriteLine("4. Check Final Exam Eligibility");
                Console.WriteLine("5. View All Students");
                Console.WriteLine("6. Exit");

                Console.Write("Enter Choice: ");
                int choice;

                Console.Write("Enter Choice: ");

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.Write("Enter Choice: ");
                }
                switch (choice)
                {
                    case 1: manager.AddStudent(); break;
                    case 2: manager.PayFees(); break;
                    case 3: manager.EnterMST(); break;
                    case 4: manager.CheckEligibility(); break;
                    case 5: manager.ViewAll(); break;
                    case 6: return;
                    default: Console.WriteLine("Invalid Choice"); break;
                }
            }
        }
    }
}