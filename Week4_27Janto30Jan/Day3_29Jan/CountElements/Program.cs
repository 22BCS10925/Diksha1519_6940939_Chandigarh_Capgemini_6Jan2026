namespace CountElements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the size: ");
            int size = int.Parse(Console.ReadLine());

            string[] arr = new string[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the input2: ");
            char input2 = char.Parse(Console.ReadLine());

            int result = UserProgramCode.GetCount(size, arr, input2);
            Console.WriteLine(result);
        }
    }
}



