namespace BankManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckAccount acc = new CheckAccount();
            Console.WriteLine("Enter the amount for Deposit: ");
            double amount = double.Parse(Console.ReadLine());

            acc.Deposit(amount);
            
            Console.WriteLine("Enter the amount for withdrawn: ");
            double amount2 = double.Parse(Console.ReadLine());
            acc.Withdraw(amount2);
           
            acc.DeductFee();

            acc.DisplayDetails();
            acc.TransactionDetails();




        }
    }
}
