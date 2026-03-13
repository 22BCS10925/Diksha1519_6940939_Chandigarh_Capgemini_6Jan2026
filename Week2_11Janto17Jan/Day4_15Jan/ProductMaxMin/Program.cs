namespace ProductMaxMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size: ");
            int n=int.Parse(Console.ReadLine());

            int[] arr=new int[n];
            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            int min = arr[0];
            int max=arr[arr.Length-1];

            int product = min * max;
            Console.WriteLine("Product will be:");
            Console.WriteLine(product);

        }
    }
}
