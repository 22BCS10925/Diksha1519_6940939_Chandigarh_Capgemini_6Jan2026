namespace InsertStringAtSpecifiedPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "HelloWorld";
            string toInsert = "A";
            int position = 5;

            char[] result = new char[original.Length + toInsert.Length];

            int i = 0;

            // Copy before position
            for (; i < position; i++)
                result[i] = original[i];

            // Copy inserted string
            for (int j = 0; j < toInsert.Length; j++)
                result[i++] = toInsert[j];

            // Copy remaining characters
            for (int k = position; k < original.Length; k++)
                result[i++] = original[k];

            Console.WriteLine(new string(result));

        }
    }
}
