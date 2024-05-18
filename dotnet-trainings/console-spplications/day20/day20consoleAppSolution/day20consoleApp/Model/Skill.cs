using System;
using System.Collections.Generic;

namespace day20consoleApp.Model
{
    public partial class Skill
    {
        public Skill()
        {
            EmployeeSkills = new HashSet<EmployeeSkill>();
        }

        public string Skill1 { get; set; } = null!;
        public string? SkillDescription { get; set; }

        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
