using System;
using System.Collections.Generic;

namespace ClinicAppDalLibrary.Model
{
    public partial class Doctor
    {
        public int Did { get; set; }
        public string? Dname { get; set; }
        public string? Dspecialization { get; set; }
        public int? Dexp { get; set; }
        public int? Dsalary { get; set; }
    }
}
