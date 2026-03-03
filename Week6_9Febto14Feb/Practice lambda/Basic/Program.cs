namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>() { 8,6,5,3,9,10 };
            int sum=li.Sum();
           // Func<int, bool> isEven = (x => x % 2 == 0);
           int evenSum=li.Where(x=>x%2==0).Sum();
            Console.WriteLine(evenSum);
            

        }
    }
}
