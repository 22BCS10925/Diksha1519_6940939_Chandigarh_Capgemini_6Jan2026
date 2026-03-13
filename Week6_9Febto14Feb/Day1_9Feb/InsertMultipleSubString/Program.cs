namespace InsertMultipleSubString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ABCDEF";
            s = s.Insert(0, "Hello");
            s = s.Insert(5, "World");
            s = s + "!";
            Console.WriteLine(s);

        }
    }
}
