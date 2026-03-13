namespace MultipleofThreeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1=new int[] {4,3,6,9,10};
            int[] arr2 = new int[6];
            foreach (int i in arr1)
            {
                if (i % 3 == 0)
                {
                    arr2[i] = i;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
