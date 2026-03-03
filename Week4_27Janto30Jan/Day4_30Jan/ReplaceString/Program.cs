namespace ReplaceString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int n=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the elements: ");
            string[] arr=new string[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]=Console.ReadLine();
            }
            Console.WriteLine("Enter the index value");
            int input2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the replaced char:");
            char ch = char.Parse(Console.ReadLine());
           UserProgramCode.Replace(arr, input2, ch);
        }
    }
}
