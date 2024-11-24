using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductManagementApp.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
