using Microsoft.AspNetCore.Mvc;
using E_CommerceOrder.Models;
using System;

namespace E_CommerceOrder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CommerceDbContext _context;

        public CustomerController(CommerceDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(_context.Customers.ToList());
        }
    }
}
