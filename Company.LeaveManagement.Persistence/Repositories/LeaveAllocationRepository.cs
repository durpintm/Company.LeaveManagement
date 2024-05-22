using Company.LeaveManagement.Application.Contracts.Persistence;
using Company.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace Company.LeaveManagement.Persistence.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly LeaveManagementDbContext _dbContext;

        public LeaveAllocationRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails()
        {
            var leaveAllocations = await _dbContext.LeaveAllocations.Include(p => p.LeaveType).ToListAsync();
            return leaveAllocations;
        }

        public async Task<LeaveAllocation> GetLeaveTypeAllocationWithDetails(int Id)
        {
            var leaveAllocation = await _dbContext.LeaveAllocations.Include(p => p.LeaveType)
                .FirstOrDefaultAsync(p => p.Id == Id);
            return leaveAllocation;
        }
    }
}
