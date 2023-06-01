using Invoice.Control.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Net.Mail;

namespace Invoice.Control.Infrastructure.Repositories.ModelBuilders
{
    public class CustomerModelBuilder : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                 .Property(x => x.Cnpj)
                 .IsRequired()
                 .HasMaxLength(14)
                 .IsFixedLength();
            builder
                .Property(x => x.CommercialName)
                .IsRequired()
                .HasMaxLength(80);
            builder
                .Property(x => x.LegalName)
                .IsRequired()
                .HasMaxLength(80);
            builder
               .Property(x => x.Phone)
               .IsRequired()
               .HasMaxLength(15);
            builder
               .Property(x => x.Email)
               .IsRequired()
               .HasMaxLength(50);
            builder
               .Property(x => x.City)              
               .HasMaxLength(50);
            builder
               .Property(x => x.State)
               .HasMaxLength(50);
            builder
               .Property(x => x.Enabled)
               .HasDefaultValue(true);
        }
    }
}
