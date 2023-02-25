using BussinssLogic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbContexts
{
    public class Tenant1DbContext : DbContext
    {
        public Tenant1DbContext(DbContextOptions<Tenant1DbContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Tenant1DbContext).Assembly);
        }
        public DbSet<Student> students { get; set; } =null!;
    }
}
