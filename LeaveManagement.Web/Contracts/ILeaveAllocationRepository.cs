using LeaveManagement.Web.Data;
using LeaveManagement.Web.Repositories;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int LeaveTypeId);

        Task<bool> AllocationExist(string employeeId, int leaveTypeId, int period);
    }
}
