using System;
using System.Collections.Generic;

namespace ClinicAppDalLibrary.Model
{
    public partial class Appointment
    {
        public int Aid { get; set; }
        public DateTime? Adate { get; set; }
        public int? Pid { get; set; }

        public virtual Patient? PidNavigation { get; set; }
    }
}
