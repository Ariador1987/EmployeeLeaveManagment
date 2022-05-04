using EmployeeLeaveManagment.Web.Contracts;
using EmployeeLeaveManagment.Web.Data;
using EmployeeLeaveManagment.Web.Models;

namespace EmployeeLeaveManagment.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
    }
}
