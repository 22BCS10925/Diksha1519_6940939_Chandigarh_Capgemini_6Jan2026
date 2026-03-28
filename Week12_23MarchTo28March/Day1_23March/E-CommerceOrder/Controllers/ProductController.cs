using E_CommerceOrder.DTO;
using E_CommerceOrder.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace E_CommerceOrder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly CommerceDbContext _context;

        public ProductController(CommerceDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Products.ToList());
        }

        //[HttpPost]
        //public IActionResult Create(Product product)
        //{
        //    _context.Products.Add(product);
        //    _context.SaveChanges();
        //    return Ok(product);
        //}
        [HttpPost]
        public IActionResult Create(ProductDTO dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Price = dto.Price,
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return Ok(product);
        }

        [HttpGet("search")]
        public IActionResult Search(string name)
        {
            var data = _context.Products
                .Where(p => p.Name.Contains(name))
                .ToList();

            return Ok(data);
        }
        [HttpGet("paged")]
        public IActionResult GetPaged(int page = 1, int pageSize = 5)
        {
            var data = _context.Products
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return Ok(data);
        }
    }
}
