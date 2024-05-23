using AutoMapper;
using Company.LeaveManagement.Application.Exceptions;
using Company.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
using Company.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveAllocation.Handlers.Commands
{
    public class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationCommand>
    {
        private readonly ILeaveAllocationRepository _LeaveAllocationRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository LeaveAllocationRepository, IMapper mapper)
        {
            _LeaveAllocationRepository = LeaveAllocationRepository;
            _mapper = mapper;
        }

        //public async Task<Unit> Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
        //{
        //    var leaveAllocation = await _LeaveAllocationRepository.Get(request.Id);

        //    if (leaveAllocation == null)
        //    {
        //        throw new NotFoundException(nameof(leaveAllocation), request.Id);
        //    }
        //    await _LeaveAllocationRepository.Delete(leaveAllocation);
        //    return Unit.Value;
        //}

        async Task IRequestHandler<DeleteLeaveAllocationCommand>.Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
        {

            var leaveAllocation = await _LeaveAllocationRepository.Get(request.Id);

            if (leaveAllocation == null)
            {
                throw new NotFoundException(nameof(leaveAllocation), request.Id);
            }
            await _LeaveAllocationRepository.Delete(leaveAllocation);
        }
    }
}
