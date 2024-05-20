using Company.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand: IRequest<int>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
