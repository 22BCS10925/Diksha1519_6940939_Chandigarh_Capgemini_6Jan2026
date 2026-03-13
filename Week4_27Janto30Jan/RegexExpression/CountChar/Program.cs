namespace CountChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string input=Console.ReadLine();
            Console.WriteLine("result: "+UserProgramCode.CountTripleRepeat(input));
        }
    }
}
