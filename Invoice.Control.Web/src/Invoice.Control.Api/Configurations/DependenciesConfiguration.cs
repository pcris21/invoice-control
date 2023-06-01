using Invoice.Control.Domain.Interfaces.Repositories;
using Invoice.Control.Domain.Interfaces.UseCases.Customer;
using Invoice.Control.Domain.UseCases.Customer;
using Invoice.Control.Infrastructure.Repositories;
using Invoice.Control.Infrastructure.Repositories.Configuration;
using Invoice.Control.Infrastructure.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Invoice.Control.Api.Configurations
{
    public static class DependenciesConfiguration
    {
        
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration) 
        {
            AddDataConfiguration(services, configuration);
            AddUseCasesConfiguration(services);
        }

        private static void AddDataConfiguration(IServiceCollection services, IConfiguration configuration)
        {
            var defaultConnection = configuration.GetConnectionString("DefaultConnection");
            var identityConnection = configuration.GetConnectionString("IdentityConnection");

            services.AddDbContext<ApplicationContext>(opt =>
            {
                opt.UseSqlServer(defaultConnection);
            });

            services.AddDbContext<IdentityContext>(opt =>
            {
                opt.UseSqlServer(identityConnection);
            });

            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));    
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ICustomerRepository,CustomerRepository>();
            services.AddTransient<ICategoryExpenseRepository, CategoryExpenseRepository>();
            services.AddTransient<IRevenueRepository, RevenueRepository>();
            services.AddTransient<IExpenseRepository, ExpenseRepository>();
        }

        private static void AddUseCasesConfiguration(IServiceCollection services)
        {
            services.AddScoped<ICreateCustomer, CreateCustomer>();
            services.AddScoped<IUpdateCustomer, UpdateCustomer>();
            services.AddScoped<IGetCustomer, GetCustomer>();
            services.AddScoped<IDisableCustomer, DisableCustomer>();
        }
    }
}
