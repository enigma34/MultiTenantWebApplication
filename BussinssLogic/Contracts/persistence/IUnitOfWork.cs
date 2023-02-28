using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinssLogic.Contracts.persistence
{
    public interface IUnitOfWork:IDisposable
    {
        //IStudentRepository StudentRepository { get; }
        Task Save();
    }
}
