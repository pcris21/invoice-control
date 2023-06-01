using Invoice.Control.Domain.Interfaces.UseCases.Customer;

namespace Invoice.Control.Domain.UseCases.Customer
{
    public class DisableCustomer : IDisableCustomer
    {
        public Task ExecuteAsync(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
