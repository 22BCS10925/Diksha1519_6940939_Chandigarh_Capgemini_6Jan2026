using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartHealthcare.API.Data;
using SmartHealthcare.Models.Entities;

namespace SmartHealthcare.API.Controllers
{
    [ApiController]
    [Route("api/Bill")]
    public class BillController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BillController(AppDbContext context)
        {
            _context = context;
        }

        // ✅ GET: api/Bill (all bills)
        // Accessible by Admin, Doctor, Patient (role-based filtering can be added)
        [HttpGet]
        [Authorize(Roles = "Admin,Doctor,Patient")]
        public async Task<IActionResult> GetAllBills()
        {
            var bills = await _context.Bills
                .Include(b => b.Appointment)
                    .ThenInclude(a => a.Patient)
                        .ThenInclude(p => p.User)
                .Include(b => b.Appointment)
                    .ThenInclude(a => a.Doctor)
                        .ThenInclude(d => d.User)
                .Include(b => b.Appointment.Prescription)
                    .ThenInclude(pr => pr.PrescriptionMedicines)
                        .ThenInclude(pm => pm.Medicine)
                .ToListAsync();

            return Ok(bills);
        }

        // ✅ GET: api/Bill/{id} (single bill by BillId)
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Doctor,Patient")]
        public async Task<IActionResult> GetBillById(int id)
        {
            var bill = await _context.Bills
                .Include(b => b.Appointment)
                    .ThenInclude(a => a.Patient)
                        .ThenInclude(p => p.User)
                .Include(b => b.Appointment)
                    .ThenInclude(a => a.Doctor)
                        .ThenInclude(d => d.User)
                .Include(b => b.Appointment.Prescription)
                    .ThenInclude(pr => pr.PrescriptionMedicines)
                        .ThenInclude(pm => pm.Medicine)
                .FirstOrDefaultAsync(b => b.BillId == id);

            if (bill == null)
                return NotFound(new { Message = "Bill not found" });

            return Ok(bill);
        }

        // ✅ POST: api/Bill (create new bill)
        [HttpPost]
        [Authorize(Roles = "Admin,Doctor")]
        public async Task<IActionResult> CreateBill([FromBody] Bill bill)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Bills.Add(bill);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBillById), new { id = bill.BillId }, bill);
        }

        // ✅ PUT: api/Bill/{id} (update bill)
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin,Doctor")]
        public async Task<IActionResult> UpdateBill(int id, [FromBody] Bill bill)
        {
            if (id != bill.BillId)
                return BadRequest();

            _context.Entry(bill).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(bill);
        }
    }
}