namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1000m);

            Console.WriteLine($"Initial Balance: {account.Balance}");

            account.Deposit(500m);
            Console.WriteLine($"After Deposit: {account.Balance}");

            try
            {
                account.Withdraw(300m);
                Console.WriteLine($"After Withdrawal: {account.Balance}");

                account.Withdraw(2000m); // will throw exception
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Program finished.");
            Console.ReadLine();
        }
    }
}
