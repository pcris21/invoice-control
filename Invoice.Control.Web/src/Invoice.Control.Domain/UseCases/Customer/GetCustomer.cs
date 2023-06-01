using Invoice.Control.Domain.Interfaces.UseCases.Customer;
using System.Linq.Expressions;

namespace Invoice.Control.Domain.UseCases.Customer
{
    public class GetCustomer : IGetCustomer
    {
        public Task<IEnumerable<Entities.Customer>> ExecuteAsync(Expression<Func<Entities.Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
