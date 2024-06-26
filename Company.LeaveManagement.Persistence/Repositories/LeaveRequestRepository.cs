﻿using Company.LeaveManagement.Application.Contracts.Persistence;
using Company.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace Company.LeaveManagement.Persistence.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly LeaveManagementDbContext _dbContext;

        public LeaveRequestRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovalStatus)
        {
            leaveRequest.Approved = ApprovalStatus;
            _dbContext.Entry(leaveRequest).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDetails(int Id)
        {
            var leaveRequest = await _dbContext.LeaveRequests.Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q=> q.Id == Id);
            return leaveRequest;
            
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetails()
        {
            var leaveRequests = await _dbContext.LeaveRequests.Include(q => q.LeaveType).ToListAsync();
            return leaveRequests;
        }
    }
}
