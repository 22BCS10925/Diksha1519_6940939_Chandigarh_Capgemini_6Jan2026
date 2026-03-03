namespace EmployeeSize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employess: ");
            int n=int.Parse(Console.ReadLine());
           // Console.WriteLine("Enter the skill level of employees: ");
            int[] arr1 = new int[n];

            
            int[] arr2 = new int[n];

            Console.WriteLine("Enter the skill level: ");
            for(int i = 0; i < n; i++)
            {
                arr1[i]=int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the size of each team: ");
            int n2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the team: ");
            for(int i = 0; i < n2; i++)
            {
                arr2[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Maximun: " + MinMax.getStrength(arr1, arr2));
        }
    }
}
