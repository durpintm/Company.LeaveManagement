using Company.LeaveManagement.Application.DTOs.Common;

namespace Company.LeaveManagement.Application.DTOs
{
    public class LeaveTypeDto: BaseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
