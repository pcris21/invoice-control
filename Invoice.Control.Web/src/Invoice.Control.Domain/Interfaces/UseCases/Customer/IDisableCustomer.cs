namespace Invoice.Control.Domain.Interfaces.UseCases.Customer
{
    public interface IDisableCustomer
    {
        Task ExecuteAsync(int customerId);
    }
}
