using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
{
    public class LoginUser
    {
        [Required]
        public string? username { get; set; }
        [Required]
        public string? passwd { get; set; }
        public string? TableAccessName { get; set; }
    }
}
