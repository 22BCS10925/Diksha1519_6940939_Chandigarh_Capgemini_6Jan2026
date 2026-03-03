namespace FlattenBinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GfG obj = new GfG();
            int[,] mat = { { 1, 5, 9 }, { 14, 20, 21 }, { 30, 34, 43 } };
            int x = 14;
            if (obj.searchMatrix(mat, x))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            
        //    int[][] mat = new int[][] {
        //    new int[] {1, 5, 9},
        //    new int[] {14, 20, 21},
        //    new int[] {30, 34, 43}
        //};
        //    int x = 14;

        //    if (obj.SearchMatrix(mat, x))
        //        Console.WriteLine("true");
        //    else
        //        Console.WriteLine("false");
        }
    }
}
