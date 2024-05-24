using AutoMapper;
using Company.LeaveManagement.Application.DTOs.LeaveAllocation;
using Company.LeaveManagement.Application.DTOs.LeaveRequest;
using Company.LeaveManagement.Application.DTOs.LeaveType;
using Company.LeaveManagement.Domain;

namespace Company.LeaveManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeDto>().ReverseMap();

        }
    }
}
