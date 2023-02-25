using BussinssLogic.Contracts.persistence;
using DataAccess.Data;
using DataAccess.DbContextFactory;
using DataAccess.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Tenant1DbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("T1")));

            services.AddDbContext<Tenant2DbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("T2")));

            services.AddScoped<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}
