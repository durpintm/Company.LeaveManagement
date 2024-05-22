using AutoMapper;
using Company.LeaveManagement.Application.DTOs.LeaveAllocation;
using Company.LeaveManagement.Application.Features.LeaveAllocation.Requests.Queries;
using Company.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveRequestListRequestHandler : IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestDto>>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestListRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocations = await _leaveAllocationRepository.GetAll();
            return _mapper.Map<List<LeaveRequestDto>>(leaveAllocations);
        }
    }
}
