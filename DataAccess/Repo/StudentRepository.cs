using BussinssLogic.Contracts.persistence;
using BussinssLogic.Models;
using DataAccess.Data;
using DataAccess.DbContextFactory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repo
{
    public class StudentRepository : IStudentRepository
    {
        // Tenant1DbContext _dbContext;
        //public StudentRepository(Tenant1DbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

      //  private readonly IDbContextFactory _dbContextFactory;

        //public StudentRepository(IDbContextFactory dbContextFactory)
        //{
        //    _dbContextFactory = dbContextFactory;
        //}

        public async Task<List<Student>> GetStudentsWithDetails(string tenantID)
        {
            //Debug.WriteLine(DBConnectionStatus());
            try
            {
                var factory = new Tenant1DbContextFactory();
                using var dbcon = factory.CreateDbContext();
                List<Student> students = await dbcon.students.FromSqlRaw("SELECT * FROM Student").ToListAsync();
                return students;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

        }

        //private bool DBConnectionStatus()
        //{
        //    try
        //    {
        //        _dbContext.Database.OpenConnection();
        //        _dbContext.Database.CloseConnection();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        var exception = ex;
        //        return false;
        //    }
        //}
    }
}
