using FluentResults;

namespace Invoice.Control.Domain.Interfaces.UseCases.Customer
{
    public interface ICreateCustomer
    {
      Task<Result> ExecuteAsync(Entities.Customer customer);
    }
}
