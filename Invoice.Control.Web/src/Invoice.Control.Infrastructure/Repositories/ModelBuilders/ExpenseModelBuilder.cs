using Invoice.Control.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invoice.Control.Infrastructure.Repositories.ModelBuilders
{
    public class ExpenseModelBuilder : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder
                .Property(e => e.Amount)
                .IsRequired()
                .HasPrecision(18, 2);
            builder
                .Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(300);
            builder
                .Property(e => e.TransactionDate)
                .IsRequired();
            builder
                .Property(e => e.BillingDate)
                .IsRequired();
            builder
                .Property(x => x.UserId)
                .IsRequired();
            builder
                .HasOne(x => x.Customer)
                .WithMany(x => x.Expenses)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired(false);
            builder
                .HasOne(x => x.Category)
                .WithMany(x => x.Expenses)
                .HasForeignKey (x => x.CategoryId)
                .IsRequired();
        }
    }
}
