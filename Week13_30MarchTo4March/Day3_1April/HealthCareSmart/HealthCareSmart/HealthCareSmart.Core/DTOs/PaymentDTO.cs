namespace HealthCareSmart.Core.DTOs
{
    public class PaymentDTO
    {
        public int BillingId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = "Cash";
        public string? Notes { get; set; }
        public string? TransactionId { get; set; }
    }

    public class PaymentRecordDTO
    {
        public int Id { get; set; }
        public int BillingId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public string? Notes { get; set; }
        public string? TransactionId { get; set; }
        public DateTime PaidAt { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}