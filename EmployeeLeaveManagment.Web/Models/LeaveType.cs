namespace EmployeeLeaveManagment.Web.Models
{
    // Represents leave types employees can have.
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        // Audit columns
        

    }
}
