namespace Invoice.Control.Domain.Interfaces.UseCases.Revenue
{
    public interface ICreateRevenue
    {
        Task<int> ExecuteAsync(Entities.Revenue revenue);
    }
}
