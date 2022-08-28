using LaunchpadCodeChallenge.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.ViewModels
{
    public class EmployeeVM
    {// empty constructor 
        public EmployeeVM() { }

        public EmployeeVM(Employee src)
        {
            Id = src.Id;
            Firstname = src.FirstName;
            LastName = src.LastName;
            Address = src.Address;
            JobTitle = src.JobTitle;
            DepartmentId = src.DepartmentId;
            DepartmentName = src.Department.Name;
        }
        //Id Identifier Guid 
        public Guid Id { get; set; }

        //FirstName
        public string Firstname { get; set; }

        //LastName
        public string LastName { get; set; }

        //Address Mailing 
        public string Address { get; set; }

        //Job title 
        public string JobTitle { get; set; }

        //Department Id 
        public Guid DepartmentId { get; set; }

        // Department name from department Entity 
        public string DepartmentName { get; set; }
    }
}
