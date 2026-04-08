using HealthCareSmart.API.Data;
using HealthCareSmart.Core.Models;
using HealthCareSmart.Core.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthCareSmart.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillingsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BillingsController(AppDbContext context)
        {
            _context = context;
        }

        // ✅ Get all billings
        [Authorize(Roles = "Admin,Doctor,Patient")]
        [HttpGet]
        public async Task<IActionResult> GetBillings()
        {
            var billings = await _context.Billings
                .Include(b => b.Appointment)
                    .ThenInclude(a => a.Doctor)
                .Include(b => b.Appointment)
                    .ThenInclude(a => a.Patient)
                        .ThenInclude(p => p.User)
                .Select(b => new
                {
                    id = b.Id,
                    appointmentId = b.AppointmentId,
                    doctorName = b.Appointment.Doctor.FullName,
                    patientName = b.Appointment.Patient.User.FullName,
                    consultationFee = b.ConsultationFee,
                    medicineCost = b.MedicineCost,
                    totalAmount = b.ConsultationFee + b.MedicineCost,
                    isPaid = b.IsPaid,
                    paidAt = b.PaidAt
                })
                .ToListAsync();

            return Ok(billings);
        }

        // ✅ Get billing by ID
        [Authorize(Roles = "Admin,Doctor,Patient")]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var billing = await _context.Billings
                .Include(b => b.Appointment).ThenInclude(a => a.Doctor)
                .Include(b => b.Appointment).ThenInclude(a => a.Patient).ThenInclude(p => p.User)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (billing == null)
                return NotFound(new { message = "Billing record not found" });

            return Ok(new BillingDTO
            {
                Id = billing.Id,
                AppointmentId = billing.AppointmentId,
                DoctorName = billing.Appointment.Doctor.FullName,
                PatientName = billing.Appointment.Patient.User.FullName,
                ConsultationFee = billing.ConsultationFee,
                MedicineCost = billing.MedicineCost,
                TotalAmount = billing.TotalAmount,
                CreatedAt = billing.CreatedAt,
                IsPaid = billing.IsPaid,
                PaidAt = billing.PaidAt
            });
        }

        // ✅ Process payment
        [Authorize(Roles = "Admin,Doctor,Patient")]
        [HttpPost("pay")]
        public async Task<IActionResult> PayBill([FromBody] PaymentDTO payment)
        {
            if (payment == null || payment.BillingId <= 0)
                return BadRequest("Invalid payment data");

            var billing = await _context.Billings.FindAsync(payment.BillingId);
            if (billing == null)
                return NotFound("Billing record not found");

            billing.IsPaid = true;
            billing.PaidAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return Ok(new { message = "Payment processed successfully" });
        }
    }
}