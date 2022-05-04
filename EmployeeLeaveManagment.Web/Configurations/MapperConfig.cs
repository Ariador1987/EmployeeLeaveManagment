using AutoMapper;
using EmployeeLeaveManagment.Web.Models;
using EmployeeLeaveManagment.Web.Models.ViewModels;

namespace EmployeeLeaveManagment.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
