using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicTrackerModelLibrary
{
    public class Appointment
    {
        

        //public Appointment( string date, string pname) {
            
        //    Date = date;
        //    PatientName = pname;
        //}
        public int AppId { get; set; }
        public DateTime Date { get; set; }
        public string PatientName {  get; set; }

    }
}
