using Company.LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestDto>>
    {

    }
}
