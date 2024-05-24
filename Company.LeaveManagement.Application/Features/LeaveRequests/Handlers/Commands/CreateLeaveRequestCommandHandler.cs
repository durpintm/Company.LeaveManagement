using AutoMapper;
using Company.LeaveManagement.Application.DTOs.LeaveRequest.Validators;
using Company.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
using Company.LeaveManagement.Application.Contracts.Persistence;
using Company.LeaveManagement.Application.Responses;
using Company.LeaveManagement.Domain;
using MediatR;
using Company.LeaveManagement.Application.Contracts.Infrastructure;
using Company.LeaveManagement.Application.Models;

namespace Company.LeaveManagement.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, BaseCommandResponse>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;

        public CreateLeaveRequestCommandHandler(
            ILeaveRequestRepository leaveRequestRepository,
            IMapper mapper,
            IEmailSender emailSender)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
            _emailSender = emailSender;
        }

        public async Task<BaseCommandResponse> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateLeaveRequestDtoValidator(_leaveRequestRepository);
            var validationResult = await validator.ValidateAsync(request.LeaveRequestDto);

            if (!validationResult.IsValid)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
                return response;
            }
            var leaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequestDto);
            leaveRequest = await _leaveRequestRepository.Add(leaveRequest);

            response.Success = true;
            response.Message = "Creation Successful";
            response.Id = leaveRequest.Id;

            var email = new Email()
            {
                To = "employee@org.com",
                Body = $"Your leave request for {request.LeaveRequestDto.StartDate:D} to {request.LeaveRequestDto.EndDate:D} " +
                $"has been submitted successfully.",
                Subject = "Leave Request Submitted"
            };

            try
            {
                await _emailSender.SendEmail(email);
            }catch(Exception ex)
            {
                // log or handle error, but do not throw
            }

            return response;
        }
    }
}
