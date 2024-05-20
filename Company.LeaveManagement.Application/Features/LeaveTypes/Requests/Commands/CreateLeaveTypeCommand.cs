using Company.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveAllocationCommand: IRequest<int>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
