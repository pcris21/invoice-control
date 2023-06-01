namespace Invoice.Control.Domain.Interfaces.UseCases.Expense
{
    public interface ICreateExpense
    {
        Task<int> ExecuteAsync(Entities.Expense expense);
    }
}
