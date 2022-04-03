using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeLeaveManagment.Web.Models
{
    // We need to give Leave Allocations depending on Leave Type to Employees => Bridge Table.
    public class LeaveAllocation : BaseEntity
    {
        // we need to know for which Leave Type is this allocation allocated
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        //public Employee Employee { get; set; }
        // Trevoir doesn't want to give this a a reference to Employee Table
        public string EmployeeId { get; set; }
        
    }
}
