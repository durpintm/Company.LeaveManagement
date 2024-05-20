using AutoMapper;
using Company.LeaveManagement.Application.DTOs.LeaveAllocation;
using Company.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries;
using Company.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Queries
{

    public class GetLeaveRequestDetailRequestHandler: IRequestHandler<GetLeaveAllocationDetailRequest, LeaveRequestDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestDetailRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<LeaveRequestDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.GetLeaveTypeAllocationWithDetails(request.Id);
            return _mapper.Map<LeaveRequestDto>(leaveAllocation);
        }
    }
} 
