using Invoice.Control.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invoice.Control.Infrastructure.Repositories.ModelBuilders
{
    public class RevenueModelBuilder : IEntityTypeConfiguration<Revenue>
    {
        public void Configure(EntityTypeBuilder<Revenue> builder)
        {
            builder
                .Property(x => x.InvoiceId)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(300);
            builder
               .Property(x => x.TransactionDate)
               .IsRequired();
            builder
               .Property(x => x.BillingDate)
               .IsRequired();
            builder
               .Property(x => x.Amount)
               .IsRequired()
               .HasPrecision(18,2);
            builder
              .Property(x => x.UserId)
              .IsRequired();
            builder
              .HasOne(x => x.Customer)
              .WithMany(x => x.Revenues)
              .HasForeignKey(x => x.CustomerId)
              .IsRequired();
        }
    }
}
