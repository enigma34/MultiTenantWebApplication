using BussinssLogic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Tenant1DbContext : DbContext
    {
        //private string connectionString;

        public Tenant1DbContext(DbContextOptions<Tenant1DbContext> options) : base(options)
        {
            
        }

        //public Tenant1DbContext(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Tenant1DbContext).Assembly);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlite("T1");
        //    }
        //}
        public DbSet<Student> students { get; set; } =null!;
    }
}
