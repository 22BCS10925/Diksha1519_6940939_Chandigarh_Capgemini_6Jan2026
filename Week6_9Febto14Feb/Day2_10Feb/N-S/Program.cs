namespace N_S
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first list:");
            int[] list1 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            Console.WriteLine("Enter second list:");
            int[] list2 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            foreach (int n in list1)
            {
                int sum = list2.Where(x => x == n).Sum();
                Console.WriteLine($"{n}-{sum}");
            }
        }
    }

}
