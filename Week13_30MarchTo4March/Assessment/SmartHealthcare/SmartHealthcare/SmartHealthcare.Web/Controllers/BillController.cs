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

        // ✅ Index: show all bills
              [HttpGet]
        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetString("JwtToken");
            if (string.IsNullOrEmpty(token))
                return Unauthorized("You must log in first.");

            _billingService.SetToken(token);

            var bills = await _billingService.GetAllBillsAsync();
            return View(bills);
        }


        // ✅ Details: show single bill
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var bill = await _billingService.GetBillByIdAsync(id);
            if (bill == null) return NotFound();
            return View(bill);
        }

        // ✅ Create (GET)
        [HttpGet]
        public IActionResult Create() => View();

        // ✅ Create (POST)
        [HttpPost]
        public async Task<IActionResult> Create(Bill bill)
        {
            if (!ModelState.IsValid) return View(bill);

            await _billingService.CreateBillAsync(bill);
            return RedirectToAction(nameof(Index));
        }

        // ✅ Edit (GET)
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var bill = await _billingService.GetBillByIdAsync(id);
            if (bill == null) return NotFound();
            return View(bill);
        }

        // ✅ Edit (POST)
        [HttpPost]
        public async Task<IActionResult> Edit(Bill bill)
        {
            if (!ModelState.IsValid) return View(bill);

            await _billingService.UpdateBillAsync(bill);
            return RedirectToAction(nameof(Index));
        }
    }
}