namespace Invoice.Control.Domain.Interfaces.UseCases.Revenue
{
    public interface IDeleteRevenue
    {
        Task ExecuteAsync(int revenueId);
    }
}
