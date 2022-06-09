using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication4.Models
{
    public partial class Employee
    {
        internal IEnumerable<Employee> employeenew;

        public int? Id { get; set; }
        public string Name { get; set; }
        public int? Departmentid { get; set; }
    }
}
