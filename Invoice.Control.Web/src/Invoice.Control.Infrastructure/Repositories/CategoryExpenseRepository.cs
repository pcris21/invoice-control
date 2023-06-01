using Invoice.Control.Domain.Entities;
using Invoice.Control.Domain.Interfaces.Repositories;
using Invoice.Control.Infrastructure.Repositories.Contexts;

namespace Invoice.Control.Infrastructure.Repositories
{
    public class CategoryExpenseRepository : BaseRepository<CategoryExpense>, ICategoryExpenseRepository
    {
        public CategoryExpenseRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
