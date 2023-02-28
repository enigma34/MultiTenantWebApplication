using BussinssLogic.Contracts.persistence;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repo
{
    public class UnitOfWork //: IUnitOfWork
    {
        //public IStudentRepository _studentRepository;

        public UnitOfWork()
        {
            
        }


        //IStudentRepository StudentRepository => _studentRepository ??= new StudentRepository(_context);

        public void Dispose()
        {
            //_context.Dispose();
            GC.SuppressFinalize(this);
        }

        //public Task Save()
        //{
        //    await _context.SaveChangesAsync();
        //}
    }
}
