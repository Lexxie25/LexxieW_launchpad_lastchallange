using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities
{
    public class Employee
    {
        //empty default constructor 
        public Employee() { }

        // Id number identifier string 
        [Key]
        public string Id { get; set; } = string.Empty;

        //FirstName 
        public string FirstName { get; set; } = string.Empty;

        //LastName 
        public string LastName { get; set; } = string.Empty;

        // mailing adddress 
        public string Address { get; set; } = string.Empty;

        //job title 
        public string JobTitle { get; set; } = string.Empty;

        // id job department 
        public string DepartmentId { get; set; }

        // relationship between Department  
        public Department Department { get; set; }
    }
}
