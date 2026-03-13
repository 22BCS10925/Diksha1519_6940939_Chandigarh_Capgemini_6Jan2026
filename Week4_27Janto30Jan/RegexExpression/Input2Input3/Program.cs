namespace Input2Input3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input1:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the input2: ");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter the input3: ");
            string input3 = Console.ReadLine();

          Console.WriteLine(  UserProgramCode.CheckOrder(input1, input2,input3));
        }
    }
}
