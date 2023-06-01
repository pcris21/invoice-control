using Invoice.Control.Domain.Interfaces.Repositories;

namespace Invoice.Control.Infrastructure.Repositories
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string DefaultConnection { get; set; } = string.Empty;
        public string IdentityConnection { get; set; } = string.Empty;

        public string GetDefaultConnection() => this.DefaultConnection;
        public string GetIdentityConnection() => this.IdentityConnection;
    }
}
