using System.ComponentModel.DataAnnotations;

namespace ProductTASK.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid UserId { get; set; }
    }
}
