namespace Invoice.Control.Domain.Interfaces.UseCases.Revenue
{
    public interface IUpdateRevenue
    {
        Task ExecuteAsync(Entities.Revenue revenue);
    }
}
