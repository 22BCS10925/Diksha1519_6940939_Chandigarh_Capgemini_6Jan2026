namespace ExtractDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Date:");
            string date = Console.ReadLine();
            Console.WriteLine("Day: "+UserProgramCode.FindDay(date));
        }
    }
}
