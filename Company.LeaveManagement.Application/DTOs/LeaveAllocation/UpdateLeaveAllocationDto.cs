﻿using Company.LeaveManagement.Application.DTOs.Common;

namespace Company.LeaveManagement.Application.DTOs.LeaveAllocation
{
    public class UpdateLeaveAllocationDto: BaseDto, ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
