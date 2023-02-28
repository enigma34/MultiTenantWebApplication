using BussinssLogic.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinssLogic.Features.SubjectEnrollments.Requests.Commands
{
    public class CreateSubjectEnrollmentCommand : IRequest<BaseCommandResponse>
    {
        public int Id { get; set; }
        public string subjects { get; set; }
        public int StudentId { get; set; }
        public string TenantId { get; set; }
    }
}
