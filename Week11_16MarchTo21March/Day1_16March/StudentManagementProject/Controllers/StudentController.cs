using Microsoft.AspNetCore.Mvc;
using StudentManagementProject.Models;

namespace StudentManagementProjects.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>();

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Id = students.Count + 1;
                students.Add(student);

                TempData["Message"] = "Student registered successfully";

                return RedirectToAction("Details", new { id = student.Id });
            }

            return View(student);
        }

        public IActionResult Details(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            return View(student);
        }
    }
}