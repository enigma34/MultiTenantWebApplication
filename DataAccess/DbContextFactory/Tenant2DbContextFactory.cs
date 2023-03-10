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
    public class Tenant2DbContextFactory : IDbContextFactory<Tenant2DbContext>
    {
        public Tenant2DbContext CreateDbContext()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<Tenant2DbContext>();
            var dbNameString = configuration.GetConnectionString("T2");

            builder.UseSqlite(dbNameString);

            return new Tenant2DbContext(builder.Options);
        }
    }
}
