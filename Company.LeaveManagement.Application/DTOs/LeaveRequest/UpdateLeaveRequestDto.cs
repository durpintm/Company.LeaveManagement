﻿using Company.LeaveManagement.Application.DTOs.Common;

namespace Company.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class UpdateLeaveRequestDto: BaseDto, ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public string RequestComments { get; set; }
        public bool Cancelled { get; set; }
    }
}
