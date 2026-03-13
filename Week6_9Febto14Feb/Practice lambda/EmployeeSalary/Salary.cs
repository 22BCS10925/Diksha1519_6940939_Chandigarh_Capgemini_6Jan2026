using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalary
{
    public class Salary
    {

       public int EmpId;
       public string Name;
       public string Designation;
        public double salary;
        public Dictionary<string, int> empList = new Dictionary<string, int>
    {
        {"Manager", 40000 },
        {"HR", 45000 },
        {"Consultant", 30000 },
        {"Software Engineer", 38000 }
    };

        //        totalSalary() : int
        public int Salaries()
        {
            int totalSalary=empList.Values.Sum();//LINQ
            //return empList.Sum(x=>x.Value);//Lambda

            return totalSalary;
        }
        //getSalary(string designation) : string
        public int GetSalary(string designation)
        {
            return empList.Where(x => x.Key == designation).Select(x => x.Value).FirstOrDefault();
        }
        //updateSalary(string designation, int newSalary) : void
        public void updateSalary(string designation, int newSalary)
        {
            if (empList.ContainsKey(designation))
            {
                empList[designation] = newSalary;
                Console.WriteLine("Salary Updated");

            }
            else
            {
                Console.WriteLine("Not updated");
            }

        }
    }
}
