using Invoice.Control.Domain.Interfaces.UseCases.Expense;

namespace Invoice.Control.Domain.UseCases.Expense
{
    public class CreateExpense : ICreateExpense
    {
        public Task<int> ExecuteAsync(Entities.Expense expense)
        {
            throw new NotImplementedException();
        }
    }
}
