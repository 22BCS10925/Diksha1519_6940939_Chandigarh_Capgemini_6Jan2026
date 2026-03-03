namespace LuckyString
{
    class Program
    {
        static void Main()
        {
            LuckyCheck obj = new LuckyCheck();
            string[] arr = { "P", "A", "S", "G", "P" , "F","H","A","B","D"};

            string result = obj.Valid(arr.Length, arr);
            Console.WriteLine(result);  
        }
    }

}
