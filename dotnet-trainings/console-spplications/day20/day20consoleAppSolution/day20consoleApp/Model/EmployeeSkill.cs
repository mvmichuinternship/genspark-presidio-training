using System;
using System.Collections.Generic;

namespace day20consoleApp.Model
{
    public partial class EmployeeSkill
    {
        public int EmployeeId { get; set; }
        public string Skill { get; set; } = null!;
        public double? SkillLevel { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual Skill SkillNavigation { get; set; } = null!;
    }
}
