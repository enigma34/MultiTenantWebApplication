using BussinssLogic.Contracts.persistence;
using BussinssLogic.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
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
        Tenant1DbContext _dbContext;
        public StudentRepository(Tenant1DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Student>> GetStudentsWithDetails()
        {
            Debug.WriteLine(DBConnectionStatus());
            try
            {
                List<Student> students = await _dbContext.students.FromSqlRaw("SELECT * FROM Student").ToListAsync();
                return students;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

        }

        private bool DBConnectionStatus()
        {
            try
            {
                _dbContext.Database.OpenConnection();
                _dbContext.Database.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                var exception = ex;
                return false;
            }
        }
    }
}
