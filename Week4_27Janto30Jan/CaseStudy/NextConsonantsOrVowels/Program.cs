namespace NextConsonantsOrVowels
{
   
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter the string : ");
            string input = Console.ReadLine();

            string result = UserProgramCode.nextString(input);
            Console.WriteLine("Next Vowel or Consonants: "+result);
        }
    }

}
