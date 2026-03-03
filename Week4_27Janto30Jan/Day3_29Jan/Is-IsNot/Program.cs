namespace Is_IsNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();

            Console.WriteLine("String: " + UserProgramCode.check(str));
        }
    }
}
