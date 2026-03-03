using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGrading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> li = new Dictionary<int, int>();

           
            li.Add(18903, 134);
            li.Add(10983, 149);
            li.Add(12343, 334);
            li.Add(14563, 350);

            // Average
            double averageGrade = li.Values.Average();
            Console.WriteLine("Average Grades of the students: " + averageGrade);

            // Risk students
            int riskValue = 150;
            var risk = li.Where(x => x.Value < riskValue);

            Console.WriteLine("\nRisk Students:");
            foreach (var x in risk)
            {
                Console.WriteLine($"RollNo: {x.Key}  Grade: {x.Value}");
            }
            Console.WriteLine("Update grades of the student after an exam: ");
            li[10983] = 160;
            foreach (var x in li)
            {

                Console.WriteLine($"RollNo: {x.Key}  Grade: {x.Value}");
            }

        }
    }
}
