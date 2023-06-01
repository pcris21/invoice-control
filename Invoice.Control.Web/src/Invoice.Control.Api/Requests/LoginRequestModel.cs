using System.ComponentModel.DataAnnotations;

namespace Invoice.Control.Api.Requests
{
    public class LoginRequestModel
    {
        [Required, EmailAddress(ErrorMessage = "A valid E-mail is required")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
