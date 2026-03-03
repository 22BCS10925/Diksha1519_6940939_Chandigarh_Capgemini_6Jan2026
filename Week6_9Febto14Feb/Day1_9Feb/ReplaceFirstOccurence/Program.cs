namespace ReplaceFirstOccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string input=Console.ReadLine();
            Console.WriteLine("Enter the string you want to replace: ");
            string rep=Console.ReadLine();
            Console.WriteLine("Enter the new replaced string: ");
            string torep=Console.ReadLine();

            string res = input.Replace(rep,torep);
            Console.WriteLine(res);
        }
    }
}
