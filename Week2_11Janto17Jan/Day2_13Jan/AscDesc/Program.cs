namespace AscDesc;

class Program
{
    static void Main()
    {
        int[] input = { 5, 2, 9, 1, 7, 3 };
        int size = input.Length;

       
        if (size < 0)
        {
            input = new int[] { -1 };
        }
        else
        {
            int mid = size / 2;

          
            Array.Sort(input, 0, mid);

          
            Array.Sort(input, mid, size - mid);
            Array.Reverse(input, mid, size - mid);
        }

        foreach (int val in input)
            Console.Write(val + " ");
    }
}
