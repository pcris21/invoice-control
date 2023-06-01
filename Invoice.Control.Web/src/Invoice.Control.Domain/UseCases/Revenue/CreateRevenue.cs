using Invoice.Control.Domain.Interfaces.UseCases.Revenue;

namespace Invoice.Control.Domain.UseCases.Revenue
{
    public class CreateRevenue : ICreateRevenue
    {
        public Task<int> ExecuteAsync(Entities.Revenue revenue)
        {
            throw new NotImplementedException();
        }
    }
}
