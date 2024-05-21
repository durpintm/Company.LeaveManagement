using Company.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
