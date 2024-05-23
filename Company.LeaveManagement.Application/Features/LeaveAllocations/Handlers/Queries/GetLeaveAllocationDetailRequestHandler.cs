using AutoMapper;
using Company.LeaveManagement.Application.Contracts.Persistence;
using Company.LeaveManagement.Application.DTOs.LeaveRequest;
using Company.LeaveManagement.Application.Features.LeaveRequests.Requests.Queries;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Queries
{

    public class GetLeaveRequestDetailRequestHandler : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestDetailRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.GetLeaveTypeAllocationWithDetails(request.Id);
            return _mapper.Map<LeaveRequestDto>(leaveAllocation);
        }
    }
}
