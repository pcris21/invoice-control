using Invoice.Control.Domain.Interfaces.UseCases.Category;
using System.Linq.Expressions;

namespace Invoice.Control.Domain.UseCases.CategoryExpense
{
    public class GetCategoryExpense : IGetCategory
    {
        public Task<IEnumerable<Entities.CategoryExpense>> ExecuteAsync(Expression<Func<Entities.CategoryExpense, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
