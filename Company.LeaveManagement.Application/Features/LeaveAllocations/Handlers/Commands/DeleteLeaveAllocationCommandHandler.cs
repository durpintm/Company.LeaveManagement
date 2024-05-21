using AutoMapper;
using Company.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
using Company.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveAllocation.Handlers.Commands
{
    public class DeleteLeaveAllocationCommandHandler: IRequestHandler<DeleteLeaveAllocationCommand>
    {
        private readonly ILeaveAllocationRepository _LeaveAllocationRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository LeaveAllocationRepository, IMapper mapper)
        {
            _LeaveAllocationRepository = LeaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _LeaveAllocationRepository.Get(request.Id);
            await _LeaveAllocationRepository.Delete(leaveRequest);
            return Unit.Value;
        }
    }
}
