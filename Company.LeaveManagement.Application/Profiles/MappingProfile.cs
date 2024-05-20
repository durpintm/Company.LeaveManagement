using AutoMapper;
using Company.LeaveManagement.Application.DTOs;
using Company.LeaveManagement.Application.DTOs.LeaveRequest;
using Company.LeaveManagement.Domain;

namespace Company.LeaveManagement.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, DTOs.LeaveRequest.LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveAllocation, DTOs.LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();

        }
    }
}
