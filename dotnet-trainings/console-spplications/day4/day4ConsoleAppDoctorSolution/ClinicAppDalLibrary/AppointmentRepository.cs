//using ClinicTrackerModelLibrary;
using ClinicAppDalLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppDalLibrary
{
    public class AppointmentRepository : IRepository<int, Appointment>
    {
        
        readonly day20EmployeeTrackerContext _appointments;

        public AppointmentRepository()
        {
            _appointments = new day20EmployeeTrackerContext();

        }
        //int GenerateID()
        //{
        //    if (_appointments.Count == 0)
        //    {
        //        return 1;
        //    }
        //    int id = _appointments.Keys.Max();
        //    return ++id;
        //}

        public Appointment Add(Appointment item)
        {
            
            _appointments.Appointments.Add(item);
            _appointments.SaveChanges();
            return item;
        }

        public Appointment Delete(int key)
        {
            var appts = _appointments.Appointments.ToList();

            var appt = appts.SingleOrDefault(a => a.Aid == key);
            _appointments.Appointments.Remove(appt);
            return null;
        }

        public Appointment Get(int key)
        {
            var appts = _appointments.Appointments.ToList();
            var appt = appts.SingleOrDefault(a => a.Aid == key);
            return appt == null ? null : appt;
        }

        public List<Appointment> GetAll()
        {
            List<Appointment> appointments = new List<Appointment>();
            var appts = _appointments.Appointments.ToList();
            foreach (var appt in appts)
            {
                appointments.Add(appt);
            }
            return appointments;
        }

        public Appointment Update(Appointment item)
        {
            _appointments.Appointments.Update(item);
            return null;
        }

    }
}
