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
        //Department String id  identifier 
        [Key]
        public string Id { get; set; } = string.Empty;

        //Name 
        public string Name { get; set; } = string.Empty;

        //Address Unique 
        public string Address { get; set; } = string.Empty;

        //relationship to employees 
        public List<Employee>? Employees { get; set; }




        //TestData q3

        Department D1 = new Department()
        {
            Id = "123QAZ",
            Name = "LaunchPad",
            Address = "9th Floor",
            Employees = new List<Employee>()
            {
                new Employee()
                { Id = "25",
                    FirstName = "Lexxie",
                    LastName = "Worth",
                    Address = "348 TestAddress",
                    JobTitle = "Jr Backend Developer ",
                    DepartmentId = "123QAZ",
                },
                new Employee()
                { Id = "26",
                    FirstName = "Osama",
                    LastName = "Malik",
                    Address = "555 TestAddress",
                    JobTitle = "Jr Frontend Developer ",
                    DepartmentId = "123QAZ",
                }

            }


        };

        Department D2 = new Department()
        {
            Id = "QWE123",
            Name = "LaunchPad v2",
            Address = "10th Floor",
            Employees = new List<Employee>()
            {
                new Employee()
                { Id = "43",
                    FirstName = "Yasin",
                    LastName = "Habib",
                    Address = "333 TestAddress",
                    JobTitle = "Jr Backend Developer ",
                    DepartmentId = "QWE123",
                },
                 new Employee()
                { Id = "44",
                    FirstName = "Nicki",
                    LastName = "Lindsrom",
                    Address = "222 TestAddress",
                    JobTitle = "Jr Frontend Developer ",
                    DepartmentId = "QWE123",
                }
            }

        };

        Department D3 = new Department()
        {
            Id = "098POI",
            Name = "LaunchPad v3",
            Address = "11th Floor",
            Employees = new List<Employee>()
            {
                new Employee()
                { Id = "1",
                    FirstName = "Jason",
                    LastName = "Lewis",
                    Address = "777 TestAddress",
                    JobTitle = "Lead Mentor ",
                    DepartmentId = "098POI",
                },
                 new Employee()
                { Id = "2",
                    FirstName = "Christie",
                    LastName = "Rodriques",
                    Address = "999 TestAddress",
                    JobTitle = "Director ",
                    DepartmentId = "098POI",
                }
            }
        };
    }


}



