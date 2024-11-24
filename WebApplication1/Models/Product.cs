using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductManagementApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        public string Tags { get; set; } // Comma-separated

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
