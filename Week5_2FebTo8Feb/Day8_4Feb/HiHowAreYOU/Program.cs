namespace HiHowAreYOU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string name=Console.ReadLine();
            string pattern = @"Hi How Are You ";
            string add = pattern + name;

            Console.WriteLine(add);

        }
    }
}
