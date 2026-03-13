namespace InsertSubstringAtposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "C programming";
            string insert = "ABC";
            int pos = 3;

            string result = s.Insert(pos, insert);
            Console.WriteLine(result);

        }
    }
}
