using ClinicAppDalLibrary;
using ClinicTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppBlLibrary
{
    public class DoctorBL: IDoctor
    {
        readonly IRepository<int, Doctor> _doctors;
        public DoctorBL( IRepository<int, Doctor> doctors) { 
            _doctors = doctors;
        }

        public Doctor AddDoctor(Doctor doctor)
        {
            var result = _doctors.Add(doctor);

            if (result != null)
            {
                return result;
            }
            throw new AddDoctorFailedException();
        }

        public Doctor DeleteDoctor(int id)
        {
            var doctors = _doctors.GetAll();
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].Id ==id)
                {
                    return doctors[i];
                    doctors[i] = null;
                }
            }
            throw new DoctorDeleteFailedException();
        }

        public Doctor GetDoctor(int id)
        {
            var doctors = _doctors.GetAll();
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].Id == id)
                {
                    return doctors[i];
                }
            }
            throw new DoctorFetchFailedException();
        }

        public Doctor UpdateDoctor(Doctor doctor)
        {
            var doctors = _doctors.GetAll();
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].Id == doctor.Id)
                {
                   doctors[i]=doctor;
                    return doctor;
                }
            }
            throw new DoctorUpdateFailedException();
        }
    }
}
