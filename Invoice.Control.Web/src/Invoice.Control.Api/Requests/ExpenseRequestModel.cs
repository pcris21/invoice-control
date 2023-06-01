namespace Invoice.Control.Api.Requests
{
    public class ExpenseRequestModel
    {
        public int CategoryId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime TransactionDate { get; set; }
        public DateTime BillingDate { get; set; }
        public int CustomerId { get; set; }
    }
}
