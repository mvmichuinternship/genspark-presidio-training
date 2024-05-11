//using ClinicTrackerModelLibrary;
using ClinicAppDalLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppDalLibrary
{
    public class PatientRepository : IRepository<int, Patient>
    {

        readonly day20EmployeeTrackerContext _patients;

        public PatientRepository()
        {
            _patients = new day20EmployeeTrackerContext();

        }
        //int GenerateID()
        //{
        //    if (_patients.Count == 0)
        //    {
        //        return 1;
        //    }
        //    int id = _patients.Keys.Max();
        //    return ++id;
        //}

        public Patient Add(Patient item)
        {

            _patients.Patients.Add(item);
            _patients.SaveChanges();
            return item;
        }

        public Patient Delete(int key)
        {
            var pats = _patients.Patients.ToList();

            var pat = pats.SingleOrDefault(a => a.Pid == key);
            _patients.Patients.Remove(pat);
            return null;
        }

        public Patient Get(int key)
        {
            var pats = _patients.Patients.ToList();
            var pat = pats.SingleOrDefault(a => a.Pid == key);
            return pat == null ? null : pat;
        }

        public List<Patient> GetAll()
        {
            List<Patient> patients = new List<Patient>();
            var pats = _patients.Patients.ToList();
            foreach (var pat in pats)
            {
                patients.Add(pat);
            }
            return patients;
        }

        public Patient Update(Patient item)
        {
            _patients.Patients.Update(item);
            return null;
        }

    }
}
