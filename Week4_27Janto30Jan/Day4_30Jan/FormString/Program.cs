namespace Form_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size: ");
            int k = int.Parse(Console.ReadLine());
            string[] arr = new string[k];
            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < k; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the index: ");
            int n = int.Parse(Console.ReadLine());

            string output = UserProgramCode.formString(arr, n);
            Console.WriteLine(output);
        }
    }
}
