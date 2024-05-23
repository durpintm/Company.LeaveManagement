using Company.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestDetailRequest : IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}
