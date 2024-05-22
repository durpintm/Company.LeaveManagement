using Company.LeaveManagement.Domain;

namespace Company.LeaveManagement.Application.Contracts.Persistence
{
    public interface ILeaveAllocationRepository: IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveTypeAllocationWithDetails(int Id);
        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
    }
}
