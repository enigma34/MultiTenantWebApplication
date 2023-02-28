using BussinssLogic.Contracts.persistence;
using BussinssLogic.Models;
using BussinssLogic.Models.T3;
using BussinssLogic.Responses;
using DataAccess.DbContextFactory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repo
{
    public class SubjectEnrollmentRepository : ISubjectEnrollmentRepository
    {        
        public async Task<SubjectEnrollment> AddSubjectEnrollment(SubjectEnrollment subjectEnrollment, string tenantID)
        {
            if (tenantID == "1")
            {
                var factory = new Tenant1DbContextFactory();
                using var dbcon = factory.CreateDbContext();
                await dbcon.subjectEnrollments.AddAsync(subjectEnrollment);
            }
            else if (tenantID == "2")
            {
                var factory = new Tenant2DbContextFactory();
                using var dbcon = factory.CreateDbContext();
                await dbcon.subjectEnrollments.AddAsync(subjectEnrollment);
            }
            else if (tenantID == "2")
            {
                var factory = new Tenant3DbContextFactory();
                using var dbcon = factory.CreateDbContext();
                await dbcon.subjectEnrollments.AddAsync(subjectEnrollment);
            }
            return subjectEnrollment;
        }
    }
}
