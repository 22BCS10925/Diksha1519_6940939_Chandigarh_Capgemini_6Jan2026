
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace TimeDate
    {
        class Program
        {
            static void Main(string[] args)
            {
            string str = Console.ReadLine();

            int ans = UserProgramCode.validateTime(str);

            if (ans == 1)
                Console.WriteLine("Valid time format");
            else if (ans == -1)
                Console.WriteLine("Invalid time format");
        }
    }
}


