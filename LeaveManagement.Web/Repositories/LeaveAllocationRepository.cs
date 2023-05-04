using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly UserManager<Employee> userManager;

        public LeaveAllocationRepository(ApplicationDbContext context,
            ILeaveTypeRepository leaveTypeRepository, UserManager<Employee> userManager) : base(context)
        {
            this.context = context;
            this.leaveTypeRepository = leaveTypeRepository;
            this.userManager = userManager;
        }

        public async Task<bool> AllocationExist(string employeeId, int leaveTypeId, int period)
        {
            return await context.LeaveAllocations.AnyAsync(q=> q.EmployeeId == employeeId 
                                                         && q.LeaveTypeId == leaveTypeId
                                                         && q.Period == period);
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();

            foreach (var employee in employees)
            {
                if (await AllocationExist(employee.Id, leaveTypeId, period))
                    continue;

                allocations.Add(new Data.LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays

                }) ;
                await AddRangeAsync(allocations);
            }
        }
    }
}
