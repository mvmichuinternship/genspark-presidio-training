using ClinicAppDalLibrary.Model;
//using ClinicTrackerModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppDalLibrary
{
    public class DoctorRepository : IRepository<int, Doctor>
    {
        readonly day20EmployeeTrackerContext _doctors;

    public DoctorRepository() 
        { 
            _doctors = new day20EmployeeTrackerContext();

        }
        //int GenerateID()
        //{
        //    if (_doctors.Count == 0)
        //    {
        //        return 1;
        //    }
        //    int id = _doctors.Keys.Max();
        //    return ++id;
        //}

        public Doctor Add(Doctor item)
        {
            //if (_doctors.ContainsValue(item))
            //{
            //    return null;
            //}
            //item.Id = GenerateID();
            //_doctors.Add(item.Id, item);
            _doctors.Doctors.Add(item);
            _doctors.SaveChanges();
            return item;
        }

        public Doctor Delete(int key)
        {
            //if (_doctors.ContainsKey(key))
            //{
            //    var doctor = _doctors[key];
            //    _doctors.Remove(key);
            //    return doctor;
            //}
            var docs = _doctors.Doctors.ToList();

            var doc = docs.SingleOrDefault(a => a.Did == key);
            _doctors.Doctors.Remove(doc);
            return null;
        }

        public Doctor Get(int key)
        {
            var docs = _doctors.Doctors.ToList();
            var doc = docs.SingleOrDefault(a => a.Did == key);
            return doc == null ? null : doc;
        }

        public List<Doctor> GetAll()
        {
            List<Doctor> doctors = new List<Doctor>();
            var docs = _doctors.Doctors.ToList();
            foreach (var doc in docs)
            {
                 doctors.Add(doc);
            }
            return doctors;
        }

        public Doctor Update(Doctor item)
        {
            //if(_doctors.ContainsKey(item.Id))
            //{
            //    _doctors[item.Id] = item;
            //    return item;
            //}
            _doctors.Doctors.Update(item);
            return null;
        }

        

        
    }
}
