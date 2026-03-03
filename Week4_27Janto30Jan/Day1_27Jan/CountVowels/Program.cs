namespace CountVowels
{
    internal class Program
    {
        public int Count(string str)
        {
            int count = 0;
            char[] res = str.ToCharArray();
           // char[] res2=new char[res.Length];
            int i = 0;
            int n = res.Length ;
            while (i < n)
            {
                if (res[i] == 'a' || res[i] == 'e' || res[i] == 'i' || res[i] == 'o' || res[i] == 'u')
                {
                 // res2[i] = res[i];
                    count++;
                }
                i++;
            }
           
            return count;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            int cnt = obj.Count(str);
            Console.WriteLine("Vowels are: " + cnt);

        }
    }
}
