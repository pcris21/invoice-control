namespace Invoice.Control.Domain.Interfaces.UseCases.Expense
{
    public interface IDeleteExpense
    {
        Task ExecuteAsync(int ExpenseId);
    }
}
