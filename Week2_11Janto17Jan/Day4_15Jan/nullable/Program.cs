namespace nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? age = null;     // nullable int
            if (age.HasValue)
            {
                Console.WriteLine(age.Value);
            }
            else
            {
                Console.WriteLine("Age not provided");
            }

        }
    }
}
