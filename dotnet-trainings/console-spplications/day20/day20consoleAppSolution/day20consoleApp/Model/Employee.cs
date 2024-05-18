using System;
using System.Collections.Generic;

namespace day20consoleApp.Model
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeSkills = new HashSet<EmployeeSkill>();
        }

        public int Eid { get; set; }
        public string? Name { get; set; }
        public string? Area { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; } = null!;
        public string? EmpArea { get; set; }

        public virtual Area? EmpAreaNavigation { get; set; }
        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
