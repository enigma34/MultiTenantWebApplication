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
    public class Tenant1DbContextFactory : IDbContextFactory<Tenant1DbContext>
    {     
       //public Tenant1DbContext CreateDbContext()
       // {
            
       // }

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
