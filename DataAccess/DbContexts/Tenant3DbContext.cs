using BussinssLogic.Models;
using BussinssLogic.Models.T3;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbContexts
{
    public class Tenant3DbContext : DbContext
    {

        public Tenant3DbContext(DbContextOptions options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Tenant2DbContext).Assembly);
        }
        public DbSet<StudentT3> students { get; set; } =null!;
    }
}
