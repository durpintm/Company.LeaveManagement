﻿using MediatR;

namespace Company.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class DeleteLeaveAllocationCommand: IRequest
    {
        public int Id { get; set; }
    }
}
