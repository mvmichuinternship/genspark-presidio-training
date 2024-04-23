using ClinicAppBlLibrary;
using ClinicAppDalLibrary;
using ClinicTrackerModelLibrary;

namespace DoctorBLTest
{
    public class Tests
    {
        IRepository<int, Doctor> repository;
        IDoctor doctorService;
        [SetUp]
        public void Setup()
        {
            repository = new DoctorRepository();
            Doctor doctor = new Doctor() {Name="mv", Experience=2, Salary=1000, Specialization="Neuro"  };
            repository.Add(doctor);
            doctorService = new DoctorBL(repository);
        }


        /// <summary>
        /// Get apointment testing
        /// </summary>

        [Test]
        public void GetDoctorTest()
        {
            var doc = doctorService.GetDoctor(1);
            Assert.IsNotNull(doc);
            Assert.AreEqual(1, doc.Id);
        }
        [Test]
        public void GetDoctorFailureTest()
        {
            var doc = doctorService.GetDoctor(1);
            Assert.IsNull(doc);
            Assert.AreNotEqual(1, doc.Id);
        }
        [Test]
        public void GetDoctorExceptionTest()
        {
            var exception = Assert.Throws<DoctorFetchFailedException>(() => doctorService.GetDoctor(2));
            Assert.AreEqual("Fetch failed", exception.Message);
        }


        /// <summary>
        /// Add Doctor testing
        /// </summary>

        [Test]
        public void AddDoctorTest()
        {
            Doctor doctor = new Doctor() { Name = "vk", Experience = 2, Salary = 1500, Specialization = "Neuro" };
            var doc = doctorService.AddDoctor(doctor);
            Assert.IsNotNull(doc);
            Assert.AreEqual(2, doc.Id);
        }
        [Test]
        public void AddDoctorFailureTest()
        {
            Doctor doctor = new Doctor() { Name = "vk", Experience = 2, Salary = 1500, Specialization = "Neuro" };
            var doc = doctorService.AddDoctor(doctor);
            Assert.IsNull(doc);
            Assert.AreNotEqual(1, doc.Id);
        }
        [Test]
        public void AddDoctorExceptionTest()    //Failure testcase.
        {
            Doctor doctor = new Doctor() { Name = "vk", Experience = 2, Salary = 150, Specialization = "Neuro" };
            var exception = Assert.Throws<AddDoctorFailedException>(() => doctorService.AddDoctor(doctor));
            Assert.AreEqual("Add operation Failed", exception.Message);
        }

        /// <summary>
        /// Delete doctor testing
        /// </summary>

        [Test]
        public void DeleteDoctorTest()
        {
            var doc = doctorService.DeleteDoctor(1);
            Assert.IsNotNull(doc);
        }
        [Test]
        public void DeleteDoctorFailureTest()
        {
            var doc = doctorService.DeleteDoctor(1);
            Assert.IsNull(doc);
        }
        [Test]
        public void DeleteDoctorExceptionTest()
        {
            var exception = Assert.Throws<DoctorDeleteFailedException>(() => doctorService.DeleteDoctor(2));
            Assert.AreEqual("Delete operation failed", exception.Message);
        }


        /// <summary>
        /// Update Doctor testing
        /// </summary>

        [Test]
        public void UpdateDoctorTest()
        {
            Doctor doctor = new Doctor() {Id=1, Name = "vk", Experience = 2, Salary = 1500, Specialization = "Neuro" };
            var doc = doctorService.UpdateDoctor(doctor);
            Assert.IsNotNull(doc);
            Assert.AreEqual(1, doc.Id);
        }
        [Test]
        public void UpdateDoctorFailureTest()
        {
            Doctor doctor = new Doctor() { Id = 1, Name = "vk", Experience = 2, Salary = 1500, Specialization = "Neuro" };
            var doc = doctorService.UpdateDoctor(doctor);
            Assert.IsNull(doc);
            Assert.AreNotEqual(1, doc.Id);
        }
        [Test]
        public void UpdateDoctorExceptionTest()    
        {
            Doctor doctor = new Doctor() { Id = 2, Name = "vk", Experience = 2, Salary = 150, Specialization = "Neuro" };
            var exception = Assert.Throws<DoctorUpdateFailedException>(() => doctorService.UpdateDoctor(doctor));
            Assert.AreEqual("Update failed", exception.Message);
        }

    }
}