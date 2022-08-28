using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities
{
    [Index(nameof(Address), IsUnique = true)]
    public class Department
    {
        //Department guid id identifier 
        [Key]
        public Guid Id { get; set; }

        //Name 
        public string Name { get; set; } = string.Empty;

        //Address Unique 
        public string Address { get; set; } = string.Empty;

        //relationship to employees 
        public List<Employee>? Employees { get; set; }
    }
}
