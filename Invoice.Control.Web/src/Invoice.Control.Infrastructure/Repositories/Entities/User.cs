using Microsoft.AspNetCore.Identity;

namespace Invoice.Control.Infrastructure.Repositories.Entities
{
    public class User : IdentityUser
    {
        public string Cnpj { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
