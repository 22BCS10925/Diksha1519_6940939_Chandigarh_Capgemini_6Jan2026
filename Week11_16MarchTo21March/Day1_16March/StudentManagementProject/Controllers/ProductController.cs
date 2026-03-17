using Microsoft.AspNetCore.Mvc;
using StudentManagementProject.Filters;
using StudentManagementProject.Models;


namespace StudentManagementProject.Controllers
{
    [LogActionFilter]
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>();

        public IActionResult Index()
        {
            // Test exception handling
            // throw new Exception("Test Exception");

            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);

            return RedirectToAction("Index");
        }
    }
}