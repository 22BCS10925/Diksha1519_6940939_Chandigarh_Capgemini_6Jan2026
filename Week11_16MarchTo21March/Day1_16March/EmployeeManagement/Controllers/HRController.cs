using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;

[ServiceFilter(typeof(LogActionFilter))]
public class HRController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult EmployeeList()
    {
        return View(); // You can pass employee list if needed
    }

    public IActionResult Reports()
    {
        throw new Exception("Test Exception in Reports");
    }
}