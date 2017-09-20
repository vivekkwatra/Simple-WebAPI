using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simple_WebAPI.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}