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
    public partial class Tenant1DbContext : DbContext
    {
        public Tenant1DbContext(DbContextOptions<Tenant1DbContext> options) : base(options){}
               
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Student> Student { get; set; } =null!;
        public DbSet<SubjectEnrollment> subjectEnrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
