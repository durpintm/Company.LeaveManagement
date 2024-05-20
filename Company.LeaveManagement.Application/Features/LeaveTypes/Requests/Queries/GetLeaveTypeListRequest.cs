using Company.LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveRequestDto>>
    {

    }
}
