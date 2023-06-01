using Invoice.Control.Domain.Interfaces.UseCases.Expense;

namespace Invoice.Control.Domain.UseCases.Expense
{
    public class UpdateExpense : IUpdateExpense
    {
        public Task ExecuteAsync(Entities.Expense expense)
        {
            throw new NotImplementedException();
        }
    }
}
