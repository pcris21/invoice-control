namespace Invoice.Control.Domain.Interfaces.UseCases.Customer
{
    public interface IUpdateCustomer
    {
        Task ExecuteAsync(Entities.Customer customer);
    }
}
