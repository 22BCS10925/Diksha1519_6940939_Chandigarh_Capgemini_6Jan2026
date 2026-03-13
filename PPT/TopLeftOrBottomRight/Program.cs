namespace TopLeftOrBottomRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
{
    { 1,  4,  7, 11 , 15 },
    { 2,  5,  8, 12,19 },
    { 3,  6,  9, 16,22 },
    {10, 13, 14, 17 ,24},
    {18,21,23,26,30}
};

            Console.WriteLine("Result for topright: ");
            Console.WriteLine(TopRight.SearchTopRight(matrix, 6));   // True
            Console.WriteLine("Result for bottom: ");
            Console.WriteLine(BottomLeft.SearchBottomLeft(matrix, 15)); // False

        }
    }
}
