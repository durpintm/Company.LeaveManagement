using AutoMapper;
using Company.LeaveManagement.Application.Contracts.Persistence;
using Company.LeaveManagement.Application.DTOs.LeaveType.Validators;
using Company.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using Company.LeaveManagement.Application.Responses;
using Company.LeaveManagement.Domain;
using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveTypeCommand, BaseCommandResponse>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveTypeDto);

            if (!validationResult.IsValid)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
                return response;
            }
            var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);
            leaveType = await _leaveTypeRepository.Add(leaveType);

            response.Success = true;
            response.Message = "Creation Successful";
            response.Id = leaveType.Id;
          
            return response;
        }
    }
}
