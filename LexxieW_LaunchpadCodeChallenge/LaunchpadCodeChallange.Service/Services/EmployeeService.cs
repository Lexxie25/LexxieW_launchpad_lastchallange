using LaunchpadCodeChallange.Repository.Repositories.Interfaces;
using LaunchpadCodeChallange.Service.Services.Interfaces;
using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallange.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        //Question 3 
        public IEnumerable<Employee> GetAll()
        {
            return new List<Employee>();
        }

        public IList<Employee> ListAll()
        {
            return new List<Employee>();
        }

        //q4

        public async Task<List<EmployeeVM>> ListAllAsync()
        {
            var results = await _employeeRepository.ListAllAsync();
            var models = results.Select(employee => new EmployeeVM(employee)).ToList();

            return models;
        }


        public async Task<List<EmployeeVM>> GetByDepartment(string departmentId)
        {
            var results = await _employeeRepository.GetByDepartment(departmentId);
            var modles = results.Select(employee => new EmployeeVM(employee)).ToList();

            return modles;
        }
    }
}
