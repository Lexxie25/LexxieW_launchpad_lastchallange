using LaunchpadCodeChallange.Repository.Repositories.Interfaces;
using LaunchpadCodeChallenge.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallange.Repository.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            var results = _context.Employees.AsEnumerable();
            return results;
        }

        public IList<Employee> ListAll()
        {
            var results = _context.Employees.ToList();
            return results;
        }

        public async Task<List<Employee>> ListAllAsync()
        {
            var results = await _context.Employees.Include(employee => employee.Department).ToListAsync();

            return results;
        }

        public async Task<List<Employee>> GetByDepartment(string departmentId)
        {
            var results = await _context.Employees.Where(employee => employee.DepartmentId == departmentId).Include(employee => employee.Department).ToListAsync();

            return results;
        }


    }
}
