using Invoice.Control.Domain.Entities;
using Invoice.Control.Domain.Interfaces.Repositories;
using Invoice.Control.Infrastructure.Repositories.Contexts;

namespace Invoice.Control.Infrastructure.Repositories
{
    public class RevenueRepository : BaseRepository<Revenue>, IRevenueRepository
    {
        public RevenueRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
