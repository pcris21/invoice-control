using Invoice.Control.Infrastructure.Repositories.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Invoice.Control.Infrastructure.Repositories.Contexts
{
    public class IdentityContext : IdentityDbContext<User>
    {
        
        public IdentityContext() {}

        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: divida técnica
            const string connectionString = "Server=DESKTOP-I5FC80S\\SQLEXPRESS;Database=Auth;User Id=AppInvoiceControl;Password=_dev@2023;Trusted_Connection=True;TrustServerCertificate=True";
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(connectionString);            
        }
    }
}
