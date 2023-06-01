using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Invoice.Control.Api.Models
{
    public class UserModel : IdentityUser
    {
       
        public string Cnpj { get; set; } = string.Empty;     
        public string CompanyName { get; set; } = string.Empty;      
        public string FullName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
