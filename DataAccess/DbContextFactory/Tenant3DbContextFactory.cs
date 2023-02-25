using DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbContextFactory
{
    public class Tenant3DbContextFactory : IDbContextFactory<Tenant3DbContext>
    {
        public Tenant3DbContext CreateDbContext()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<Tenant3DbContext>();
            var dbNameString = configuration.GetConnectionString("T3");

            builder.UseSqlite(dbNameString);

            return new Tenant3DbContext(builder.Options);
        }
    }
}
