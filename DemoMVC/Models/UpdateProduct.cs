using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
{
    public class UpdateProduct
    {
        [Required(ErrorMessage = "Enter a valid SKU")]
        public string? SKU { get; set; }
        [Required(ErrorMessage = "Stock value can't be empty")]
        public int Stock { get; set; }

    }
}
