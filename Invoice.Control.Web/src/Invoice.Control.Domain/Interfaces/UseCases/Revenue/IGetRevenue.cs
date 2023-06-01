using System.Linq.Expressions;

namespace Invoice.Control.Domain.Interfaces.UseCases.Revenue
{
    public interface IGetRevenue
    {
        Task<IEnumerable<Entities.Revenue>> GetExecuteAsync(Expression<Func<Entities.Revenue, bool>> filter);
    }
}
