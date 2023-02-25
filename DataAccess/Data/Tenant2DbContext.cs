using BussinssLogic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Tenant2DbContext : DbContext
    {
        private string connectionString;

        public Tenant2DbContext(DbContextOptions options) : base(options)
        {
            
        }

        public Tenant2DbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(Tenant1DbContext).Assembly);
        //}
        public DbSet<Student> students { get; set; } =null!;
    }
}
