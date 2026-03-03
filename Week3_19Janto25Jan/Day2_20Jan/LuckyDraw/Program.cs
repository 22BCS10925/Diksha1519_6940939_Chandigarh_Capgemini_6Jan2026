namespace LuckyDraw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1, input2;
            input1 = Convert.ToInt16(Console.ReadLine());
            input2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(Marks.luckynumbers(input1, input2));
        }

    }
}
