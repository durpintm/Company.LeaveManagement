﻿using Company.LeaveManagement.Application.Persistence.Contracts;
using FluentValidation;

namespace Company.LeaveManagement.Application.DTOs.LeaveAllocation.Validators
{
    public class CreateLeaveAllocationDtoValidator: AbstractValidator<CreateLeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;

        public CreateLeaveAllocationDtoValidator(ILeaveAllocationRepository leaveAllocationRepository)
        {
            _leaveAllocationRepository = leaveAllocationRepository;

            Include(new ILeaveAllocationDtoValidator(leaveAllocationRepository));
        }
    }
}
