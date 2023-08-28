using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RA.PowerSupplySystem.Application.Contracts.Persistence;
using RA.PowerSupplySystem.Persistence.DatabaseContext;
using RA.PowerSupplySystem.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.PowerSupplySystem.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RaDatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("RaDatabaseConnectionString"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IMaterialEntryRepository, MaterialEntryRepository>();
            services.AddScoped<IMaterialRepository, MaterialRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IProductMaterialRepository, ProductMaterialRepository>();
            return services;
        }
    }

}
