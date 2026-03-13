namespace MaximumDeletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string input = Console.ReadLine();
            int cnt = 0;
            for(int i = 0; i < input.Length; i++)
            {
                for(int j = i + 1; j < input.Length; j ++)
                {
                    if (input[i] == input[j]){
                        cnt++;
                    }

                }
            }
            Console.WriteLine("Maximum deletion: " + cnt);
        }
    }
}
