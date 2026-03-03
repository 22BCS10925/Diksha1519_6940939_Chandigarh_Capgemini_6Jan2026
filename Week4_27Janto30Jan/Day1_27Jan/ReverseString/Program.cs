namespace ReverseString
{
    internal class Program
    {
        public string Reverse(string s)
        {
            char[] res;
            res = s.ToCharArray();

            int l = 0;
            int r = res.Length - 1;
           

            while (l < r)
            {
                char temp = res[l];
                res[l] = res[r];
                res[r] = temp;

                l++;
                r--;

            }
            
            return new string(res);

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Enter the string: ");
            string str=Console.ReadLine();

            string result=obj.Reverse(str);
            Console.WriteLine(result);
           
        }
    }
}
