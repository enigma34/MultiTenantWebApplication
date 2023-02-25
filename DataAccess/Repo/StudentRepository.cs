using BussinssLogic.Contracts.persistence;
using BussinssLogic.Models;
using DataAccess.DbContexts;
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
        public async Task<List<Student>> GetStudentsWithDetails(string tenantID)
        {
            List<Student> students = new List<Student>();
            try
            {
                if (tenantID=="1")
                {
                    var factory = new Tenant1DbContextFactory();
                    using var dbcon = factory.CreateDbContext();
                    students = await dbcon.students.FromSqlRaw("SELECT * FROM Student").ToListAsync();
                }
                else if (tenantID == "2")
                {
                    var factory = new Tenant2DbContextFactory();
                    using var dbcon = factory.CreateDbContext();
                    students = await dbcon.students.FromSqlRaw("SELECT * FROM Student").ToListAsync();
                }
                else if (tenantID == "3")
                {
                    var factory = new Tenant3DbContextFactory();
                    using var dbcon = factory.CreateDbContext();
                    var studentsT3 = await dbcon.students.FromSqlRaw("SELECT * FROM Student").ToListAsync();
                    foreach (var tempStudent in studentsT3)
                    {
                        students.Add(new Student
                        {
                            Id = tempStudent.Id,
                            Name = tempStudent.FirstName + " " + tempStudent.LastName,
                            Age = tempStudent.Age,
                            Email = tempStudent.Email,
                            Mobile = tempStudent.Mobile,
                            Address = tempStudent.Address + " " + tempStudent.City,
                        });
                    }
                }
                return students;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }
    }
}
