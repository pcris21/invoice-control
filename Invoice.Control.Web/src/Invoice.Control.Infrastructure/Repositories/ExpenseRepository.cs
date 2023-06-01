using Invoice.Control.Domain.Entities;
using Invoice.Control.Domain.Interfaces.Repositories;
using Invoice.Control.Infrastructure.Repositories.Contexts;

namespace Invoice.Control.Infrastructure.Repositories
{
    public class ExpenseRepository : BaseRepository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
