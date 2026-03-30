using System.ComponentModel.DataAnnotations;

namespace Project_1.Models
{
    public class SchoolSupply
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public int QuantityAvailable { get; set; }
    }
}