namespace DeleteAlterating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            char[] res = new char[str.Length / 2] ;
            

            int j = 0;
            //for even indexs
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    res[j] = str[i];
                    j++;
                }

              
                
            }
            Console.WriteLine(new string(res)); 


        }
    }
}
