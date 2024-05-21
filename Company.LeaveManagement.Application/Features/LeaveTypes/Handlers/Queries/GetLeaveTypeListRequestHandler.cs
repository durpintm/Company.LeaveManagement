 using AutoMapper;
using Company.LeaveManagement.Application.DTOs.LeaveType;
using Company.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries;
using Company.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _LeaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeListRequestHandler(ILeaveTypeRepository LeaveTypeRepository, IMapper mapper)
        {
            _LeaveTypeRepository = LeaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var LeaveTypes = await _LeaveTypeRepository.GetAll();
            return _mapper.Map<List<LeaveTypeDto>>(LeaveTypes);
        }
    }
}
