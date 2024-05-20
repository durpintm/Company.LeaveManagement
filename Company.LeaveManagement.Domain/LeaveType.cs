using Company.LeaveManagement.Domain.Common;

namespace Company.LeaveManagement.Domain
{
    public class LeaveType: BaseDomainEntity
    {
        public string Name { get; set; } 
        public int DefaultDays { get; set; }
    }
}
