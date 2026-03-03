namespace MaxDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int n=int.Parse(Console.ReadLine());

            int[] arr=new int[n];
            Console.WriteLine("Enter the elements: ");
            for(int i = 0; i < n; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MaxDiffernce: "+Difference.Diff(arr,n));
        }
    }
}
