namespace Palindrome
{
    internal class Program
    {
        public static bool PalindromeCheck(string str)
        {
            //char[] res=str.ToCharArray();
            int l = 0;
            int r = str.Length - 1;
            while (l < r)
            {
                if (str[l] != str[r])
                {
                    return false;
                }
                l++;
                r--;
            }
            return true ;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            bool res=PalindromeCheck(str);
            Console.WriteLine(res);


        }
    }
}
