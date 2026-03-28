using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ECommerceOrderAPI.Models
{
    //[Table("tableOrders")]


    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
