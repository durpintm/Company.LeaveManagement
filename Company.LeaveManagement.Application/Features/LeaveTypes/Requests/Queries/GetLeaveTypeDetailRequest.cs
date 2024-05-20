using Company.LeaveManagement.Application.DTOs;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
