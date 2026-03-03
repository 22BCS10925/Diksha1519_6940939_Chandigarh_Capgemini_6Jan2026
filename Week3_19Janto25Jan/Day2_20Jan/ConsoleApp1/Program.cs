using System;
using System.Linq;
using System.Xml.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Step 1: Create an XML document
            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Students",
                    new XElement("Student",
                        new XAttribute("Id", 1),
                        new XElement("Name", "Alice"),
                        new XElement("Age", 20)
                    ),
                    new XElement("Student",
                        new XAttribute("Id", 2),
                        new XElement("Name", "Bob"),
                        new XElement("Age", 22)
                    )
                )
            );

            // Step 2: Save to file
            doc.Save("studentsDoc.xml");

            // Step 3: Load back from file
            XDocument loadedDoc = XDocument.Load("studentsDoc.xml");

            // Step 4: Query with LINQ
            var query = from s in loadedDoc.Descendants("Student")
                        where (int)s.Element("Age") > 20
                        select new
                        {
                            Name = s.Element("Name")?.Value,
                            Age = (int)s.Element("Age")
                        };

            // Step 5: Print results
            foreach (var student in query)
            {
                Console.WriteLine($"{student.Name} - {student.Age}");
            }
        }


    }
}