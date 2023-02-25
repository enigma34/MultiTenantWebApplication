using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbContextFactory
{
    public class Tenant1DbContextFactory : IDbContextFactory<Tenant1DbContext>
    {
        //private readonly IConfiguration _configuration;

        //public Tenant1DbContextFactory()
        //{
        //}

        //public Tenant1DbContextFactory(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}


        //public Tenant1DbContext CreateDbContext()
        //{
        //    var connectionString = _configuration.GetConnectionString("T1");
        //    //return new Tenant1DbContext(connectionString);
        //    var optionsBuilder = new DbContextOptionsBuilder<Tenant1DbContext>();
        //    optionsBuilder.UseSqlite(connectionString);

        //    return new Tenant1DbContext(optionsBuilder.Options);
        //}      
        public Tenant1DbContext CreateDbContext()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<Tenant1DbContext>();
            var dbNameString = configuration.GetConnectionString("T1");

            builder.UseSqlite(dbNameString);

            return new Tenant1DbContext(builder.Options);
        }
    }
}
