using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace PatientCaseStudy
{
    internal class PatientBO
    {
        public void DisplayPatientDetails(List<Patient> patientList, string name)
        {
            List<Patient> p1 = (from p in patientList
                                where p.Name == name
                                select p).ToList();
            int le = p1.Count;

            if (le < 0)
            {
                Console.Write("Employee named {0} not found", name); ;
            }
            else
            {
                Console.WriteLine("Name   Age   illness   City");
                foreach (Patient x1 in p1)
                {
                    Console.WriteLine(x1.ToString());
                }



            }
        }
        public void DisplayYoungestPatientDetails(List<Patient> patientList)
        {

            int Age = (from p in patientList
                       select p.age).Min();
            var x = from p in patientList
                    where p.age == Age
                    select p;

            Console.WriteLine("Name                 Age   Designation          City");
            foreach (var x1 in x)
            {
                Console.WriteLine(x1.ToString());
            }
        }
        public void displayPatientsFromCity(List<Patient> patientList, string cname)
        {
            List<Patient> li = (from p in patientList
                                where p.city == cname
                                select p).ToList();
            int le = li.Count;

            if (le < 0)
            {
                Console.Write("Employee named {0} not found", cname); ;
            }
            else
            {

                Console.WriteLine("Name                 Age   Designation          City");

                foreach (var x in li)
                {
                    Console.WriteLine(x.ToString());
                }

            }


        }
    }
}


