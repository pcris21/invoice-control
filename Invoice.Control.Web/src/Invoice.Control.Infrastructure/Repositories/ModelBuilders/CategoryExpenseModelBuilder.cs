using Invoice.Control.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invoice.Control.Infrastructure.Repositories.ModelBuilders
{
    public class CategoryExpenseModelBuilder : IEntityTypeConfiguration<CategoryExpense>
    {
        public void Configure(EntityTypeBuilder<CategoryExpense> builder)
        {
            builder
                .Property(x => x.CategoryName)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(300);
            builder
                .Property(x => x.Enabled)
                .HasDefaultValue(true);
        }
    }
}
