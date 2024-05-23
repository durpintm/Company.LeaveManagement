using AutoMapper;
using Company.LeaveManagement.MVC.Models;
using Company.LeaveManagement.MVC.Services.Base;

namespace Company.LeaveManagement.MVC
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateLeaveTypeDto, CreateLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveTypeDto, LeaveTypeVM>().ReverseMap();


        }
    }
}
