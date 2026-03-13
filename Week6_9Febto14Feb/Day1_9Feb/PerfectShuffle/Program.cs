namespace PerfectShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string x");
            string x = Console.ReadLine();
            Console.WriteLine("Enter the string y");
            string y = Console.ReadLine();
            Console.WriteLine("Enter the string z");
            string z = Console.ReadLine();  
            Console.WriteLine(Shuffle.IsPerfectShuffle(x, y, z));
        }
    }
}
