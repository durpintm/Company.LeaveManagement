using Company.LeaveManagement.Application.DTOs.LeaveType;
using Company.LeaveManagement.Application.Responses;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class UpdateLeaveTypeCommand: IRequest<BaseCommandResponse>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
