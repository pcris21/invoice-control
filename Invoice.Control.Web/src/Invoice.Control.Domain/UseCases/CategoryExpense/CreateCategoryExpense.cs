using Invoice.Control.Domain.Interfaces.UseCases.CategoryExpense;

namespace Invoice.Control.Domain.UseCases.CategoryExpense
{
    public class CreateCategoryExpense : ICreateCategory
    {
        public Task<int> ExecuteAsync(Entities.CategoryExpense category)
        {
            throw new NotImplementedException();
        }
    }
}
