namespace DigitSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size: ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            string[] arr=new string[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("sum : " + UserProgramCode.getSum(arr));
        }
    }
}
