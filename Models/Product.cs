using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductService.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)] // Set max length for database
        public string ProductName { get; set; }

        [MaxLength(1000)] // Optional, allows longer descriptions
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal WholesalePrice { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal RetailPrice { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
