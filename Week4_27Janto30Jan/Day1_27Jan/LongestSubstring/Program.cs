namespace LongestSubstring
{
    internal class Program
    {
        public static int Substring(string s)
        {
            
            int maxCount = 0;
            Dictionary<char,int> map=new Dictionary<char, int> ();
            int left = 0;
            for(int right=0;right<s.Length;right++)
            {
                if (map.ContainsKey(s[right])&& map[s[right]]>=left)
                {
                    left=map[s[right]]+1;


                }
               
                else
                {
                    map[s[right]] = right;
                    
                    maxCount = Math.Max(maxCount, right - left + 1);

                }
            }
            return maxCount;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str=Console.ReadLine();
            int cnt = Substring(str);
            Console.WriteLine("Count will be: "+cnt);
        }
    }
}
