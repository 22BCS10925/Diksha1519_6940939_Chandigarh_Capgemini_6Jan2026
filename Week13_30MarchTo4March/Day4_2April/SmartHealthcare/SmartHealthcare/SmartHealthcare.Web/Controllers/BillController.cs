using Microsoft.AspNetCore.Mvc;
using SmartHealthcare.Models.Entities;
using SmartHealthcare.Web.Services;

namespace SmartHealthcare.Web.Controllers
{
    public class BillController : Controller
    {
        private readonly BillingService _billingService;

        public BillController(BillingService billingService)
        {
            _billingService = billingService;
        }
        

        // ✅ Index: fetch all bills from your service or database
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var bills = await _billingService.GetAllBillsAsync(); // no HttpClient here
            return View(bills);
        }

        // ✅ Create (GET)
        [HttpGet]
        public IActionResult Create() => View();

        // ✅ Create (POST)
        [HttpPost]
        public async Task<IActionResult> Create(Bill bill)
        {
            if (!ModelState.IsValid)
                return View(bill);

            await _billingService.CreateBillAsync(bill);
            return RedirectToAction(nameof(Index));
        }
        

        
    }
}