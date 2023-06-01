using Invoice.Control.Domain.Commons;

namespace Invoice.Control.Domain.Entities
{
    public class Expense : Entity
    {
        
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime TransactionDate { get; set; }
        public DateTime BillingDate { get; set; }
        public int CustomerId { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public Customer Customer { get; set; }
        public CategoryExpense Category { get; set; }
    }
}
