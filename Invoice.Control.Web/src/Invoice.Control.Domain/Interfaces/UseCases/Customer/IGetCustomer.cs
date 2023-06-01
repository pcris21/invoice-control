using System.Linq.Expressions;

namespace Invoice.Control.Domain.Interfaces.UseCases.Customer
{
    public interface IGetCustomer
    {
        Task<IEnumerable<Entities.Customer>> ExecuteAsync(Expression<Func<Entities.Customer, bool>> filter);
    }
}
