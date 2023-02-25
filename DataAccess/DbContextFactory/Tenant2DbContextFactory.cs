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
    //public class Tenant2DbContextFactory : IDbContextFactory
    //{
    //    private readonly IConfiguration _configuration;

    //    public Tenant2DbContextFactory(IConfiguration configuration)
    //    {
    //        _configuration = configuration;
    //    }
    //    DbContext IDbContextFactory.CreateDbContext()
    //    {
    //        var connectionString = _configuration.GetConnectionString("T2");
    //        return new Tenant2DbContext(connectionString);
    //    }
    //}
}
