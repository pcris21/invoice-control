namespace Invoice.Control.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        ICategoryExpenseRepository Categories { get; }
        IExpenseRepository Expenses { get; }
        IRevenueRepository Revenues { get; }
        Task SaveAsync();
    }
}
