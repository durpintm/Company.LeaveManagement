using Company.LeaveManagement.Application.DTOs.LeaveAllocation;
using Company.LeaveManagement.Application.Responses;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand: IRequest<BaseCommandResponse>
    {
        public CreateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
