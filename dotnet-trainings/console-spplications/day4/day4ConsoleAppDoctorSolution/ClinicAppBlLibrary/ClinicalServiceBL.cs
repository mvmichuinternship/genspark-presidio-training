using ClinicAppDalLibrary;
using ClinicTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppBlLibrary
{
    public class ClinicalServiceBL : IClinicalServices
    {
        readonly IRepository<int, Appointment> _clinicalServices;
        public ClinicalServiceBL(IRepository<int, Appointment> clinicalRepository)
        {
            //_departmentRepository = new DepartmentRepository();//Tight coupling
            _clinicalServices = clinicalRepository;//Loose coupling
        }
        public Appointment AddNewAppointment(Appointment item)
        {
            var appointments = _clinicalServices.GetAll();
            for (int i = 0; i < appointments.Count; i++)
            {
                if (appointments[i].Date != item.Date)
                {
                    var result = _clinicalServices.Add(item);

                    if (result != null)
                    {
                        return result;
                    }
                }
            }
                
            throw new DuplicateTimeException();
        }

        public Appointment CancelAppointment(int id)
        {
            var appointments = _clinicalServices.GetAll();
            for (int i = 0; i < appointments.Count; i++)
            {
                if (appointments[i].AppId == id)
                {
                    return appointments[i];
                    appointments[i] = null;
                }
            }
            throw new AppointmentDeleteFailedException();
        }

        public Appointment GetAppointmentDetails(int id)
        {
            var appointments = _clinicalServices.GetAll();
            for (int i = 0; i < appointments.Count; i++)
            {
                if (appointments[i].AppId == id)
                {
                    return appointments[i];
                }
            }
            throw new AppointmentNotFoundException();
        }

        //public Appointment SortAppointmentBasedOnDate(Appointment item)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
