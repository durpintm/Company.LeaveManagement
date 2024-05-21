using Company.LeaveManagement.Application.DTOs.LeaveRequest;
using Company.LeaveManagement.Application.Responses;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand: IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
