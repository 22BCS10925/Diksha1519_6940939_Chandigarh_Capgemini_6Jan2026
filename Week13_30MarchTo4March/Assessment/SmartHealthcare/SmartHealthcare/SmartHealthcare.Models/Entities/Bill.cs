using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHealthcare.Models.Entities
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }

        [ForeignKey("Appointment")]
        public int AppointmentId { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ConsultationFee { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal MedicineCharges { get; set; }

        // Computed property for total
        [NotMapped]
        public decimal TotalAmount => ConsultationFee + MedicineCharges;

        [Required]
        [StringLength(20)]
        public string PaymentStatus { get; set; } = "Unpaid"; // Default

        public Appointment? Appointment { get; set; }
    }
}