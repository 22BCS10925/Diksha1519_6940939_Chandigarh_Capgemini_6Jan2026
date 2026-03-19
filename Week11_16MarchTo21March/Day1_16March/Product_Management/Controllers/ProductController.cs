using Microsoft.AspNetCore.Mvc;
using Product_Management.Filters;
using Product_Management.Models;
using System.Collections.Generic;

namespace Product_Management.Controllers
{
    [ServiceFilter(typeof(LogActionFilter))]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
    {
        new Product{Id=1, Name="Laptop", Price=80000},
        new Product{Id=2, Name="Phone", Price=50000},
        new Product{Id=3, Name="Headphones", Price=5000}
    };

            return View(products);
        }
    }
}