using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation :BaseEntity
    {
       

        public DateTime NumberOfDays { get; set; }

        public LeaveType LeaveType { get; set; }
        [ForeignKey("LeaveTypeId")] // optional 
        public int LeaveTypeId { get; set; }

        public string EmployeeId { get; set; }
       
       


    }
}
