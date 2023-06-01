using Invoice.Control.Domain.Interfaces.UseCases.Revenue;
using System.Linq.Expressions;

namespace Invoice.Control.Domain.UseCases.Revenue
{
    public class GetRevenue : IGetRevenue
    {
        public Task<IEnumerable<Entities.Revenue>> GetExecuteAsync(Expression<Func<Entities.Revenue, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
