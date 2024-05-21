using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class DeleteLeaveRequestCommand: IRequest
    {
        public int Id { get; set; }
    }
}
