using CollegeManagement.Models;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagement.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>();

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            s.CheckAdmission();
            students.Add(s);
            return RedirectToAction("Index");
        }

        public IActionResult PayFees(int id)
        {
            var student = students.FirstOrDefault(s => s.ID == id);
            return View(student);
        }

        [HttpPost]
        public IActionResult PayFees(Student s)
        {
            var student = students.FirstOrDefault(x => x.ID == s.ID);

            if (student != null)
            {
                student.FeesPaid = s.FeesPaid;
                student.HasDue = s.HasDue;
            }

            return RedirectToAction("Index");
        }

        public IActionResult EnterMST(int id)
        {
            var student = students.FirstOrDefault(s => s.ID == id);
            return View(student);
        }

        [HttpPost]
        public IActionResult EnterMST(Student s)
        {
            var student = students.FirstOrDefault(x => x.ID == s.ID);

            if (student != null)
                student.MSTMarks = s.MSTMarks;

            return RedirectToAction("Index");
        }

        public IActionResult CheckEligibility(int id)
        {
            var student = students.FirstOrDefault(s => s.ID == id);

            ViewBag.Result = student?.CheckFinalEligibility();

            return View(student);
        }
    }
}