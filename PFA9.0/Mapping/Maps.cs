using AutoMapper;
using PFA9._0.Data;
using PFA9._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFA9._0.Mapping
{
    public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, DetailsLeaveTypeVM>().ReverseMap(); 
            CreateMap<LeaveType, CreateLeaveTypeVM>().ReverseMap(); 
            CreateMap<LeaveType, LeaveHistoryVM>().ReverseMap(); 
            CreateMap<LeaveType, LeaveAllocationVM>().ReverseMap(); 
            CreateMap<Employee, EmployeeVM>().ReverseMap(); 
        }
    }
}
