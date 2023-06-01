namespace Invoice.Control.Domain.Interfaces.UseCases.Expense
{
    public interface IUpdateExpense
    {
        Task ExecuteAsync(Entities.Expense expense);
    }
}
