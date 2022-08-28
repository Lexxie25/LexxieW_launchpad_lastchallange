using LaunchpadCodeChallange.Service.Services.Interfaces;
using LaunchpadCodeChallenge.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallange.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        //Question 3 
        public IEnumerable<Employee> GetAll()
        {
            return new List<Employee>();
        }

        public IList<Employee> ListAll()
        {
            return new List<Employee>();
        }
    }
}
