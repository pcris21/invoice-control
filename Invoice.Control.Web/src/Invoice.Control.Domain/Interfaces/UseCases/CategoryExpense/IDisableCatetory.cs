namespace Invoice.Control.Domain.Interfaces.UseCases.CategoryExpense
{
    public interface IDisableCatetory
    {
        Task ExecuteAsync(int Id);
    }
}
