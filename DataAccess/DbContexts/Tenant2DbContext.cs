using BussinssLogic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbContexts
{
    public class Tenant2DbContext : DbContext
    {

        public Tenant2DbContext(DbContextOptions<Tenant2DbContext> options) : base(options){}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(Tenant2DbContext).Assembly);
        //}
        public DbSet<Student> Student { get; set; } =null!; 
        public DbSet<SubjectEnrollment> subjectEnrollments { get; set; }
    }
}
