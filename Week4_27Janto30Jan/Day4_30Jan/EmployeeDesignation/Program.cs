namespace EmployeeDesignation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the element");
            string[] str = new string[n];

            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the designation you want to check");
            string input2 = Console.ReadLine();

            string[] res = UserProgramCode.getEmployee(str, input2);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("Person having same designation as " + input2 + " is: " + res[i]);
            }
        }
    }
}
