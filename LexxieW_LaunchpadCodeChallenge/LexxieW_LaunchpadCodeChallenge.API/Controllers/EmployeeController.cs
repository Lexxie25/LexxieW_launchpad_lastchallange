using LaunchpadCodeChallange.Service.Services.Interfaces;
using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LexxieW_LaunchpadCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //Q4
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        //Get all employees
        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            var results = _employeeService.GetAll();
            return results;
        }

        [HttpGet]
        public IList<Employee> ListAll()
        {
            return _employeeService.ListAll();
        }



        [HttpGet("department/{departmentId}")]
        public async Task<ActionResult<List<EmployeeVM>>> GetByDepartment([FromRoute] string departmentId)
        {
            var results = await _employeeService.GetByDepartment(departmentId);
            return Ok(results);
        }



        [HttpGet]
        public async Task<ActionResult<List<EmployeeVM>>> ListAllAsync()
        {
            var results = await _employeeService.ListAllAsync();
            return Ok(results);
        }

    }
}
