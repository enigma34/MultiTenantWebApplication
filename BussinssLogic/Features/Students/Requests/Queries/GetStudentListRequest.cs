using BussinssLogic.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinssLogic.Features.Students.Requests.Queries
{
    public class GetStudentListRequest: IRequest<List<Student>>
    {
    }
}
