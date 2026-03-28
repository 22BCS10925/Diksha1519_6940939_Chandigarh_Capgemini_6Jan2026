using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{

    public class ShippingDetail
    {
        public int Id { get; set; }

        [Required]
        public string Address { get; set; }

        public string Status { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
