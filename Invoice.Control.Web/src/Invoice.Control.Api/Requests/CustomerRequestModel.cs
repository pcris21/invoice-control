using System.ComponentModel.DataAnnotations;

namespace Invoice.Control.Api.Requests
{
    public class CustomerRequestModel
    {
        [Required(ErrorMessage ="The CNPJ is required")]
        [StringLength(14, ErrorMessage = "The CNPJ must have 14 characters")]
        public string Cnpj { get; set; } = string.Empty;
       
        [Required(ErrorMessage = "The Commercial Name is required")]
        public string CommercialName { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "The Legal name is required")]
        public string LegalName { get; set; } = string.Empty;
        [Required, MinLength(10, ErrorMessage = "The Phone number must have at least 10 characters")]
        public string Phone { get; set; } = string.Empty;
        [Required, EmailAddress(ErrorMessage ="A valid E-mail is required")]
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
      
    }
}
