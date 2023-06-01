using FluentResults;
using Invoice.Control.Domain.Interfaces.Repositories;
using Invoice.Control.Domain.Interfaces.UseCases.Customer;

namespace Invoice.Control.Domain.UseCases.Customer
{
    public class CreateCustomer : ICreateCustomer
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateCustomer(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> ExecuteAsync(Entities.Customer customer)
        {
            var result = await _unitOfWork.Customers.FindAsync(x => x.Id == customer.Id);
            if (result.Any()) return Result.Fail("The customer is already register");

            await _unitOfWork.Customers.InsertAsync(customer);
            await _unitOfWork.SaveAsync();

            return Result.Ok();
        }
    }
}
