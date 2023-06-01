namespace Invoice.Control.Domain.Interfaces.UseCases.CategoryExpense
{
    public interface ICreateCategory
    {
        Task<int> ExecuteAsync(Entities.CategoryExpense category);
    }
}
