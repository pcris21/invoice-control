using Invoice.Control.Domain.Entities;
using Invoice.Control.Infrastructure.Repositories.ModelBuilders;
using Microsoft.EntityFrameworkCore;

namespace Invoice.Control.Infrastructure.Repositories.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(){}

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CategoryExpense> CategoriesExpenses { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        public DbSet<Revenue> Revenues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            //TODO: divida técnica
            const string connectionString = "Server=DESKTOP-I5FC80S\\SQLEXPRESS;Database=InvoiceControl;User Id=AppInvoiceControl;Password=_dev@2023;Trusted_Connection=True;Encrypt=False;";
            
            if (!optionsBuilder.IsConfigured)            
                optionsBuilder.UseSqlServer(connectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CustomerModelBuilder().Configure(modelBuilder.Entity<Customer>());  
            new ExpenseModelBuilder().Configure(modelBuilder.Entity<Expense>());
            new CategoryExpenseModelBuilder().Configure(modelBuilder.Entity<CategoryExpense>());
            new RevenueModelBuilder().Configure(modelBuilder.Entity<Revenue>());
        }

    }
}
