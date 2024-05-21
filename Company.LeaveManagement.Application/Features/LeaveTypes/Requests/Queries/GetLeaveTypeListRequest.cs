using Company.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {

    }
}
