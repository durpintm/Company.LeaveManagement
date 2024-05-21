using AutoMapper;
using Company.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using Company.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class DeleteLeaveAllocationCommandHandler: IRequestHandler<DeleteLeaveTypeCommand>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveAllocationCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveTypeRepository.Get(request.Id);
            await _leaveTypeRepository.Delete(leaveRequest);
            return Unit.Value;
        }
    }
}
