using System.Linq.Expressions;

namespace Invoice.Control.Domain.Interfaces.UseCases.Category
{
    public interface IGetCategory
    {
        Task<IEnumerable<Entities.CategoryExpense>> ExecuteAsync(Expression<Func<Entities.CategoryExpense, bool>> filter);
    }
}
