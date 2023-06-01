using Invoice.Control.Domain.Interfaces.Repositories;
using Invoice.Control.Infrastructure.Repositories.Contexts;

namespace Invoice.Control.Infrastructure.Repositories.Configuration
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;

        private readonly ApplicationContext _dbContext;
        public ICustomerRepository Customers { get; }
        public ICategoryExpenseRepository Categories { get; }
        public IExpenseRepository Expenses { get; }
        public IRevenueRepository Revenues { get; }

        public UnitOfWork(ApplicationContext dbContext,
            ICustomerRepository customerRepository,
            ICategoryExpenseRepository categoryExpenseRepository,
            IExpenseRepository expensesRepository,
            IRevenueRepository revenueRepository)
        {
            _dbContext = dbContext;
            Customers = customerRepository;
            Categories = categoryExpenseRepository;
            Expenses = expensesRepository;
            Revenues = revenueRepository;
        }
        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
