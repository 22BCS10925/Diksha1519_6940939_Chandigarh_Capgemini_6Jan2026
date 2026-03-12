using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;
using StudentMVC.Services;

public class StudentController : Controller
{
    private readonly StudentDBContext _context;
    private readonly IRequestLogService _logService;

    public StudentController(StudentDBContext context, IRequestLogService logService)
    {
        _context = context;
        _logService = logService;
    }

    // Display students
    public IActionResult Index()
    {
        var students = _context.students.ToList();

        ViewBag.Logs = _logService.GetLogs();

        return View(students);
    }

    // GET: Create
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Student student)
    {
        if (ModelState.IsValid)
        {
            _context.students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(student);
    }
}
