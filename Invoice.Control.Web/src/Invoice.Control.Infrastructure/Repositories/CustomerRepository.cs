using Invoice.Control.Domain.Entities;
using Invoice.Control.Domain.Interfaces.Repositories;
using Invoice.Control.Infrastructure.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Invoice.Control.Infrastructure.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
