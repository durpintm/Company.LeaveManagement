using Company.LeaveManagement.Application.DTOs.Common;
using Company.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.LeaveManagement.Application.DTOs
{
    public class LeaveRequestDto: BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
