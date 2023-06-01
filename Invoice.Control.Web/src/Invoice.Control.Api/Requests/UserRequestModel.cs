using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Invoice.Control.Api.Requests
{
    public class UserRequestModel  
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }= string.Empty;
        [Required]
        [MinLength(6, ErrorMessage = "The field {0} must have at least 6 characters")]
        public string Password { get; set; } = string.Empty;

        [Compare("Password", ErrorMessage = "The password does not match ")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [StringLength(14, ErrorMessage = "The field {0} must have 14 characters")]
        [Required(ErrorMessage = "The field {0} is required")]
        public string Cnpj { get; set; } = string.Empty;

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50)]
        public string CompanyName { get; set; } = string.Empty;
        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(80)]
        public string FullName { get; set; } = string.Empty;
        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;

    }
}
