namespace SortAndInsert
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size: ");
            int n=int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());


                if (arr[i] < 0)
                {
                    Console.WriteLine("-1");
                    return;
                }
            }
            Console.WriteLine("Enter the element you want to insert: ");
            int newElement = int.Parse(Console.ReadLine());

            Array.Sort(arr);

            
            int index = FindInsertPosition(arr, newElement);

            
            int[] result = new int[arr.Length + 1];

          
            for (int i = 0, j = 0; i < result.Length; i++)
            {
                if (result[i] < 0)
                {
                    result[i] = -1;
                    break;
                }
                if (i == index)
                    result[i] = newElement;
                else
                    result[i] = arr[j++];
            }

          
            Console.WriteLine("Array after insertion:");
            foreach (int x in result)
                Console.Write(x + " ");
        }

       
        static int FindInsertPosition(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            int mid = 0;

            while (left <= right)
            {
                mid = (left + right) / 2;

                if (arr[mid] == target)
                    return mid; 
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return left;
        }
    }

}

