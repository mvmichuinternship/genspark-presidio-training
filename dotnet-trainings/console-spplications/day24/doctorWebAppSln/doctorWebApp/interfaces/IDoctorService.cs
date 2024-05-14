using doctorWebApp.models;

namespace doctorWebApp.interfaces
{
    public interface IDoctorService
    {
        public Task<IEnumerable<Doctor>> GetDoctorBySpecialization(string specialization);
        public Task<Doctor> UpdateDoctorExperience(int id, int experience);
        public Task<IEnumerable<Doctor>> GetDoctors();
    }
}
