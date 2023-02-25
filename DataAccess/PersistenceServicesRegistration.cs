using BussinssLogic.Contracts.persistence;
using DataAccess.DbContexts;
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
            services.AddDbContext<Tenant1DbContext>();
            services.AddDbContext<Tenant2DbContext>();
            services.AddDbContext<Tenant3DbContext>();

            services.AddScoped<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}
