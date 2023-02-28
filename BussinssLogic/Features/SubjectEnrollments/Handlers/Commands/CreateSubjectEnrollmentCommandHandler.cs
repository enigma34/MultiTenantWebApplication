using BussinssLogic.Contracts.persistence;
using BussinssLogic.Features.SubjectEnrollments.Requests.Commands;
using BussinssLogic.Models;
using BussinssLogic.Models.T3;
using BussinssLogic.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinssLogic.Features.SubjectEnrollments.Handlers.Commands
{
    public class CreateSubjectEnrollmentCommandHandler : IRequestHandler<CreateSubjectEnrollmentCommand, BaseCommandResponse>
    {
        readonly ISubjectEnrollmentRepository _subjectEnrollmentRepository;
        //readonly IUnitOfWork _unitOfWork;

        public CreateSubjectEnrollmentCommandHandler(ISubjectEnrollmentRepository subjectEnrollmentRepository)
        {
            _subjectEnrollmentRepository = subjectEnrollmentRepository;
        }
        public async Task<BaseCommandResponse> Handle(CreateSubjectEnrollmentCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            try
            {
                var subjectEnrolment = new SubjectEnrollment
                {
                    StudentId = request.StudentId,
                    SubjectsList = request.subjects
                };
                if (request.TenantId == "2")
                {
                    //get student age
                    //if age is below 21 dont allow to enrole
                    return response;
                }
                else
                {
                    subjectEnrolment = await _subjectEnrollmentRepository.AddSubjectEnrollment(subjectEnrolment, request.TenantId);
                    response.Success = true;
                    response.Message = "Creation Successful";
                    response.Id = subjectEnrolment.Id;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Creation failed";
                response.Errors = ex.Message;
                return response;
            }
           
        }
    }
}
