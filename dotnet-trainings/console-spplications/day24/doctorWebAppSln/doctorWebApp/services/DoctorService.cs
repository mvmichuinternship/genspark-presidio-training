using doctorWebApp.interfaces;
using doctorWebApp.models;

namespace doctorWebApp.services
{
    public class DoctorService : IDoctorService
    {

        private readonly IRepository<int, Doctor> _repository;

        public DoctorService(IRepository<int, Doctor> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Doctor>> GetDoctorBySpecialization(string specialization)
        {
            var doctors = await GetDoctors();
            if (doctors.Count() == 0)
                throw new Exception();
            var list = doctors.Where(doc => doc.Specialization == specialization).ToList();
            return list;
        }

        public async Task<IEnumerable<Doctor>> GetDoctors()
        {
            var doctors = await _repository.Get();
            if (doctors.Count() == 0)
                throw new Exception();
            return doctors;
        }

        public async Task<Doctor> UpdateDoctorExperience(int id, int experience)
        {
            var doctor = await _repository.Get(id);
            if (doctor == null)
                throw new Exception();
            doctor.Experience = experience;
            doctor = await _repository.Update(doctor);
            return doctor;
        }
    }
}
