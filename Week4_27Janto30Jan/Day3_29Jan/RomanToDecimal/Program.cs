namespace RomanToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string i=Console.ReadLine();
            Console.WriteLine("Result: "+UserProgramcode.getDecimal(i));
        }
    }
}
