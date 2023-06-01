using Invoice.Control.Domain.Commons;

namespace Invoice.Control.Domain.Entities
{
    public class CategoryExpense : Entity
    {
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool Enabled { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}
