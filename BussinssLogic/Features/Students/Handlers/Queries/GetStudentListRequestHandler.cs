using BussinssLogic.Contracts.persistence;
using BussinssLogic.Features.Students.Requests.Queries;
using BussinssLogic.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinssLogic.Features.Students.Handlers.Queries
{
    public class GetStudentListRequestHandler : IRequestHandler<GetStudentListRequest, List<Student>>
    {
        readonly IStudentRepository _studentRepository;

        public GetStudentListRequestHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<Student>> Handle(GetStudentListRequest request, CancellationToken cancellationToken)
        {
            var students = new List<Student>();
                students = await _studentRepository.GetStudentsWithDetails(request.TenantId);
            return students;
        }
    }
}
