using Company.LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest : IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}
