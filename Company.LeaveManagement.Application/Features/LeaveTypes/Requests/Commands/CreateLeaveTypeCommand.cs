using Company.LeaveManagement.Application.DTOs.LeaveType;
using Company.LeaveManagement.Application.Responses;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand: IRequest<BaseCommandResponse>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}
