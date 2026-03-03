namespace ProductSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            string line;
            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                string[] parts = line.Split('-');
                string id = parts[0];
                int sale = int.Parse(parts[1]);

                if (!map.ContainsKey(id) || map[id] < sale)
                    map[id] = sale;
            }

            foreach (var item in map.OrderByDescending(x => x.Value))
                Console.WriteLine($"{item.Key}-{item.Value}");
        }
    }

}
