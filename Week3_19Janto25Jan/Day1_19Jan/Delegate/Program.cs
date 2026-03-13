namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiClass obj = new MultiClass();
            Math m = new Math(obj.add);
            m += obj.sub;
            m += obj.mult;
            m+= obj.div;
            m(100, 80);
            Console.WriteLine();
            m(80, 799);
            Console.WriteLine();
            m -= obj.mult;
            m(890, 87);
            Console.ReadLine();

        }
    }
}
