using BussinssLogic.Features.Students.Requests.Queries;
using BussinssLogic.Features.SubjectEnrollments.Requests.Commands;
using BussinssLogic.Models;
using BussinssLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiTenantWebApplication.DTOs;

namespace MultiTenantWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> Get([FromQuery]string tenantId)
        {
            var students = await _mediator.Send(new GetStudentListRequest() { TenantId=tenantId});
            return Ok(students);
        }

        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Add([FromBody] SubjectEnrollmentDTO subjectEnrollmentDTO)
        {
            var students = await _mediator.Send(new CreateSubjectEnrollmentCommand() 
            {
                Id = subjectEnrollmentDTO.Id,
                subjects = subjectEnrollmentDTO.Subjects,
                StudentId=subjectEnrollmentDTO.StudentId,
                TenantId=subjectEnrollmentDTO.tenantId                 
            });
            return Ok(students);
        }
    }
}
