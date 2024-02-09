using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
{
    public class Product
    {
        [Required]
        public string ProductId { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Features { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
        public int Warranty { get; set; }
        public int Rating { get; set; }
        [Required]
        public int VendorId { get; set; }
    }

}
