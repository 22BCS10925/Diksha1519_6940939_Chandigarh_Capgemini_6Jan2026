namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size: ");
            int n=int.Parse(Console.ReadLine());
            int[] arr=new int[n];
            Console.WriteLine("Enter the elements:");
            for(int i=0;i<arr.Length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter target: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine(getSum.Sum(arr, target));
        }
    }
}
