namespace Invoice.Control.Api.Requests
{
    public class RevenueRequestModel
    {
        public string InvoiceId { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime TransactionDate { get; set; }
        public DateTime BillingDate { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
    }
}
