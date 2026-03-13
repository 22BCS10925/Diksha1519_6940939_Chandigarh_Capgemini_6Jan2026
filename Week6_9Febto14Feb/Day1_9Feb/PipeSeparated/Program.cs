namespace PipeSeparated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "dog|cat|apple";
            var words = input.Split('|');
            Array.Sort(words);
            Console.WriteLine(string.Join("|", words));

        }
    }
}
