namespace FirstNonReapeating
{
    internal class Program
    {
        public static char RepeatingCheck(string str)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach(char c in str)
            {
                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map[c] = 1;
                }

            }
            foreach(char c in str)
            {
                if (map[c] == 1)
                {
                    return c;
                }

            }

            return'\0';
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str=Console.ReadLine();

            char c=RepeatingCheck(str);
            Console.WriteLine(c);
            

        }
    }
}
