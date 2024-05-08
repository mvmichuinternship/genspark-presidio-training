using System;
using System.Collections.Generic;

namespace ClinicAppDalLibrary.Model
{
    public partial class Patient
    {
        public Patient()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Pid { get; set; }
        public string? Pname { get; set; }
        public string? Pgender { get; set; }
        public string? Pnumber { get; set; }
        public string? Pemail { get; set; }
        public DateTime? Pdob { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
