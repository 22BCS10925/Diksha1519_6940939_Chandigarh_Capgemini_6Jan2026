using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniProject
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentID { get; set; }
    }

    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }

    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int DepartmentID { get; set; }
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public string Grade { get; set; }
    }

    // Record class INSIDE namespace
    public class Record
    {
        public void GetOlderStudents(List<Student> students)
        {
            var olderStudents = students.Where(s => s.Age > 21);

            foreach (var student in olderStudents)
            {
                Console.WriteLine($"Older student {student.Name} is {student.Age} years old");
            }
        }

        public void getRecord(List<Department> department,List<Course> course)
        {
            int csDeptId = department
                .Where(d => d.DepartmentName == "CSE")
                .Select(d => d.DepartmentID)
                .FirstOrDefault();
          
            var csCourses = course.Where(c => c.DepartmentID == csDeptId);
            foreach (var c in csCourses)
            {
                Console.WriteLine($"{ c.CourseID} {c.CourseName}");
            }

        }
        public void getEnrollment(List<Enrollment> enrollments,List<Course> courses)
        {
            int courseId=courses.Where(c=>c.CourseName =="DataBase").Select(c=>c.CourseID).FirstOrDefault();
            var enroll = enrollments.Where(c => c.EnrollmentID == courseId);
            foreach(var e in enroll)
            {
                Console.WriteLine($"{e.EnrollmentID} {e.StudentID}");
            }
        }
    }
}