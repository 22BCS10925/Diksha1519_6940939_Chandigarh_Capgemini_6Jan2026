namespace Count500_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[] { 500, 100, 50, 10, 1 };
            Console.WriteLine("Enter the Amount: ");
            int num=int.Parse(Console.ReadLine());
            int count = 0;
            int res = 0;
            foreach(int i in arr){
                count = num / i;
                num=num % i;

                Console.WriteLine(i + " - " + count);

                res += count;

            }
            Console.WriteLine(res);
        }
    }
}
