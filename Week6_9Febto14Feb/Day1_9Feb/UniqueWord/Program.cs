namespace UniqueWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "listen", "silent", "hello", "world", "abc", "cba" };

            var map = new Dictionary<string, int>();

            foreach (var w in words)
            {
                string key = String.Concat(w.OrderBy(c => c));
                map[key] = map.ContainsKey(key) ? map[key] + 1 : 1;
            }

            foreach (var w in words)
            {
                string key = String.Concat(w.OrderBy(c => c));
                if (map[key] == 1)
                    Console.Write(w + " ");
            }
        }
    }
}
