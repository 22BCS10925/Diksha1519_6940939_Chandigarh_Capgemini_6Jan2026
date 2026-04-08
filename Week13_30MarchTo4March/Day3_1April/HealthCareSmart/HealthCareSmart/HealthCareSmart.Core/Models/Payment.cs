using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCareSmart.Core.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [Required]
        public int BillingId { get; set; }
        public Billing Billing { get; set; } = null!;

        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }

        public int? DoctorId { get; set; }
        public Doctor? Doctor { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [MaxLength(50)]
        public string PaymentMethod { get; set; } = "Cash";

        [MaxLength(500)]
        public string? Notes { get; set; }

        public DateTime PaidAt { get; set; } = DateTime.UtcNow;

        [MaxLength(100)]
        public string? TransactionId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = "Completed"; // Completed, Pending, Failed
    }
}
