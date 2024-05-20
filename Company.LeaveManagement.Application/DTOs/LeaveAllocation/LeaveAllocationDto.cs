using Company.LeaveManagement.Application.DTOs.Common;
using Company.LeaveManagement.Application.DTOs.LeaveType;

namespace Company.LeaveManagement.Application.DTOs.LeaveAllocation
{
    public class LeaveRequestDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
